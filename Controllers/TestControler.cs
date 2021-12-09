/*using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;

namespace CalHFAWebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
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

            List<String> statuscodes = new List<String>(preCloseStatusCodes.Count + postCloseStatusCodes.Count);

            foreach (int code in preCloseStatusCodes)
            {
                statuscodes.Add("" + code);
                statuscodes.Add(", ");
            }

            foreach (int code in postCloseStatusCodes)
            {
                statuscodes.Add("" + code);
                statuscodes.Add(", ");
            }

            if (statuscodes.Count <= 0)
                return BadRequest();

            statuscodes.RemoveAt(statuscodes.Count - 1);

            String queryText = "SELECT mx.StatusCode, mx.StatusDate " +
                                "FROM(SELECT loanstatus.*, row_number() OVER(PARTITION BY loanID ORDER BY StatusSequence DESC) num FROM loanstatus) mx " +
                                    "INNER JOIN loan AS lon ON lon.LoanID = mx.LoanID " +
                                    "INNER JOIN loantype AS lt ON lon.LoanTypeID = lt.LoanTypeID " +
                                "WHERE num = 1 AND mx.StatusCode IN("+ statuscodes.ToArray() + ") " +
                                    "AND (lt.LoanCategoryID = case when mx.StatusCode > 500 then 2 ELSE 1 END) ORDER BY mx.StatusCode";

            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (MySqlCommand query = new MySqlCommand(queryText, connection))
                {
                    MySqlDataReader results = query.ExecuteReader();

                    if (!results.HasRows)
                        return BadRequest();

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
}
*/