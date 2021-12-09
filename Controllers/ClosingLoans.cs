using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;

namespace CalHFAWebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClosingLoans : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] LoanType? type, [FromQuery] List<int> preCloseStatusCodes, [FromQuery] List<int> postCloseStatusCodes)
        {
            // Set default parameters if none provided (AKA clean url https://calhfaapi.azurewebsites.net/api/closingloans)
            type ??= LoanType.BOTH;
            preCloseStatusCodes = preCloseStatusCodes.Any() ? preCloseStatusCodes : (type == LoanType.BOTH ? new List<int>(new int[] { 410, 422 }) : type == LoanType.PRE_CLOSING ? new List<int>(new int[] { 410, 422 }) : new List<int>());
            postCloseStatusCodes = postCloseStatusCodes.Any() ? postCloseStatusCodes : (type == LoanType.BOTH ? new List<int>(new int[] { 510, 522 }) : type == LoanType.POST_CLOSING ? new List<int>(new int[] { 510, 522 }) : new List<int>());

            var StatusCodes = new SortedDictionary<int, int>();
            var StatusDates = new Dictionary<int, DateTime>();

            if (preCloseStatusCodes.Count <= 0 && postCloseStatusCodes.Count <= 0)
                return BadRequest("No Status Codes specified.");

            String queryText = "SELECT mx.StatusCode, mx.StatusDate " +
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
                        return BadRequest("No loans for given Status Codes: " + preCloseStatusCodes.Concat(postCloseStatusCodes));

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

            var Response = new JsonResult(JsonObject);
            Response.StatusCode = ((int)HttpStatusCode.OK);
            Response.ContentType = "application/json";

            return Response;

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
