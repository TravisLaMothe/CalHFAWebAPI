using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using MySqlConnector;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;

namespace CalHFAWebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClosingLoans : ControllerBase
    {
        private const int CacheAbsoluteExpiration = 60; // In Minutes - Time from creation of cache before releasing cached data and pulling new data from database
        private const int CacheSlidingExpiration = 10;  // In Minutes - Time between client hits before releasing cached data

        private readonly IMemoryCache _memoryCache;
        public ClosingLoans(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

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

                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    using (MySqlCommand query = new MySqlCommand(queryText, connection))
                    {
                        DatabaseConnection.AddArrayParameters(query, "StatusCodes", preCloseStatusCodes.Concat(postCloseStatusCodes));

                        MySqlDataReader results = query.ExecuteReader();

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
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum LoanType
    {
        PRE_CLOSING,
        POST_CLOSING,
        BOTH
    }
}
