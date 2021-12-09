using CalHFAWebAPI.Constants;
using CalHFAWebAPI.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using MySqlConnector;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;

namespace CalHFAWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClosingLoans : ControllerBase
    {
        private const int CacheAbsoluteExpiration = 60; // In Minutes - Time from creation of cache before releasing cached data and pulling new data from database
        private const int CacheSlidingExpiration = 10;  // In Minutes - Max time between client hits before releasing cached data

        private readonly IMemoryCache _memoryCache;
        public ClosingLoans(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        /// <summary>
        ///     <para>
        ///         The HttpGet request of the API. Accepts conditional parameters based on the request URL. <paramref name="type"/>, <paramref name="preCloseStatusCodes"/>, and <paramref name="postCloseStatusCodes"/> are all
        ///         optional parameters. Default values included in documentation. This API call will pull requested status codes and check if they are in line or not. Compares pre-closing loans to First category status and 
        ///         post-closing loans to Subordinate category status. Also calculates the count and most recent date of the loans per status code for review.
        ///     </para>
        /// </summary>
        /// 
        /// <param name="type">Type of StatusCode requested. Options: <see cref="LoanType"/>. Default value: <see cref="LoanType.BOTH"/>  </param>
        /// <param name="preCloseStatusCodes">List of pre-close status codes. Defaults provided by client: 410, 422</param>
        /// <param name="postCloseStatusCodes">List of post-close status codes. Defaults provided by client: 510, 522</param>
        /// 
        /// <returns>
        ///     Returns a JsonResult carrying the HttpResponseCode as well as the Json formatted output.
        /// </returns>
        /// <exception cref="BadRequest">
        ///     Error thrown upon different actions occuring. For example, no loans in a status code will throw HttpCode 400 with a message informing the missing value.
        /// </exception>
        [HttpGet]
        public IActionResult Get([FromQuery] LoanType? type, [FromQuery] List<int> preCloseStatusCodes, [FromQuery] List<int> postCloseStatusCodes)
        {
            // Set default parameters if none provided (AKA clean url https://calhfaapi.azurewebsites.net/api/closingloans)
            type ??= LoanType.BOTH;
            preCloseStatusCodes = preCloseStatusCodes.Any() ? preCloseStatusCodes : (type == LoanType.BOTH ? new List<int>(new int[] { 410, 422 }) : type == LoanType.PRE_CLOSING ? new List<int>(new int[] { 410, 422 }) : new List<int>());
            postCloseStatusCodes = postCloseStatusCodes.Any() ? postCloseStatusCodes : (type == LoanType.BOTH ? new List<int>(new int[] { 510, 522 }) : type == LoanType.POST_CLOSING ? new List<int>(new int[] { 510, 522 }) : new List<int>());

            var cacheKey = "" + type + ":" + String.Join(",", preCloseStatusCodes) + ":" + String.Join(",", postCloseStatusCodes);

            if (!_memoryCache.TryGetValue(cacheKey, out JsonResult json))
            {
                var StatusCodes = new SortedDictionary<int, int>();
                var StatusDates = new Dictionary<int, DateTime>();

                if (preCloseStatusCodes.Count <= 0 && postCloseStatusCodes.Count <= 0)
                    return BadRequest("No Status Codes specified.");

                var queryText = "SELECT mx.StatusCode, mx.StatusDate " +
                                    "FROM(SELECT loanstatus.*, row_number() OVER(PARTITION BY loanID ORDER BY StatusSequence DESC) num FROM loanstatus) mx " +
                                        "INNER JOIN loan AS lon ON lon.LoanID = mx.LoanID " +
                                        "INNER JOIN loantype AS lt ON lon.LoanTypeID = lt.LoanTypeID " +
                                    "WHERE num = 1 AND mx.StatusCode IN({StatusCodes}) " +
                                        "AND (lt.LoanCategoryID = case when mx.StatusCode > 500 then 2 ELSE 1 END)";

                using (dynamic connection = DatabaseConstants.USE_MYSQL ? MySQLConnection.GetConnection() : SQLServerConnection.GetConnection())
                {
                    using (dynamic query = DatabaseConstants.USE_MYSQL ? new MySqlCommand(queryText, connection) : new SqlCommand(queryText, connection))
                    {
                        AddArrayParameters(query, "StatusCodes", preCloseStatusCodes.Concat(postCloseStatusCodes));

                        dynamic results = query.ExecuteReader();

                        if (!results.HasRows)
                            return BadRequest("No loans for given Status Code(s): " + String.Join(",", preCloseStatusCodes.Concat(postCloseStatusCodes)));

                        while (results.Read())
                        {
                            DateTime StatusDate = results.GetDateTime(results.GetOrdinal("StatusDate"));
                            int StatusCode = results.GetInt32(results.GetOrdinal("StatusCode"));
                            if (StatusDates.ContainsKey(StatusCode))
                            {
                                StatusDates.TryGetValue(StatusCode, out var oldestDate);
                                if (StatusDate.CompareTo(oldestDate) < 0)
                                    StatusDates[StatusCode] = StatusDate;
                            }
                            else
                            {
                                StatusDates.Add(StatusCode, StatusDate);
                            }

                            if (StatusCodes.ContainsKey(StatusCode))
                            {
                                StatusCodes.TryGetValue(StatusCode, out var currentCount);
                                StatusCodes[StatusCode] = currentCount + 1;
                            }
                            else
                            {
                                StatusCodes.Add(StatusCode, 1);
                            }
                        }
                    }
                }

                var JsonObject = from statusCode in StatusCodes.Keys select new { StatusCode = statusCode, Date = StatusDates[statusCode].ToString("yyyy-MM-dd"), Count = StatusCodes[statusCode] };

                var cacheExpiryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddMinutes(CacheAbsoluteExpiration), // Data updated every hour at a maximum
                    Priority = CacheItemPriority.High,
                    SlidingExpiration = TimeSpan.FromMinutes(CacheSlidingExpiration) // Data updated if no twoclients access data 10 minutes apart
                };

                _memoryCache.Set(cacheKey, json = new JsonResult(JsonObject), cacheExpiryOptions);
            }

            json.StatusCode = ((int)HttpStatusCode.OK);
            json.ContentType = "application/json";

            return json;
        }

        private void AddArrayParameters<T>(dynamic cmd, string paramNameRoot, IEnumerable<T> values)
        {
            var parameterNames = new List<string>();
            var paramNumber = 1;
            foreach (var value in values)
            {
                var paramName = string.Format("@{0}{1}", paramNameRoot, paramNumber++);
                parameterNames.Add(paramName);
                dynamic p = DatabaseConstants.USE_MYSQL ? new MySqlParameter(paramName, value) : new SqlParameter(paramName, value);
                cmd.Parameters.Add(p);
            }

            cmd.CommandText = cmd.CommandText.Replace("{" + paramNameRoot + "}", string.Join(",", parameterNames));
        }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum LoanType
    {
        PRE_CLOSING,
        POST_CLOSING,
        BOTH
    }
}
