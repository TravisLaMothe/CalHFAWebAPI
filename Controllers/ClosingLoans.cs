using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace CalHFAWebAPI.Controllers
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LoanType
    {
        PRE_CLOSING,
        POST_CLOSING,
        BOTH
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ClosingLoans : ControllerBase
    {
        [HttpGet]
        public JsonResult Get([FromQuery] LoanType? type, [FromQuery] List<int> preCloseStatusCodes, [FromQuery] List<int> postCloseStatusCodes) // 400-499 preclosing, 500-599 postclosing
        {
            type ??= LoanType.BOTH;
            preCloseStatusCodes = preCloseStatusCodes.Any() ? preCloseStatusCodes : (type == LoanType.BOTH ? new List<int>(new int[] { 410, 422 }) : type == LoanType.PRE_CLOSING ? new List<int>(new int[] { 410, 422 }) : new List<int>());
            postCloseStatusCodes = postCloseStatusCodes.Any() ? postCloseStatusCodes : (type == LoanType.BOTH ? new List<int>(new int[] { 510, 522 }) : type == LoanType.POST_CLOSING ? new List<int>(new int[] { 510, 522 }) : new List<int>());

            var StatusCodes = new SortedDictionary<int, int>();
            var StatusDates = new Dictionary<int, DateTime>();
            var LoanTypeCategories = new Dictionary<int, int>();
            var Loans = new Dictionary<int, int>();

            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (MySqlCommand query = new MySqlCommand("SELECT LoanTypeID, LoanCategoryID FROM LoanType", connection))
                {
                    MySqlDataReader results = query.ExecuteReader();

                    while (results.Read())
                    {
                        int LoanTypeID = results.GetInt32(results.GetOrdinal("LoanTypeID"));
                        int LoanCategoryID = results.GetInt32(results.GetOrdinal("LoanCategoryID"));

                        LoanTypeCategories.Add(LoanTypeID, LoanCategoryID);
                    }

                    results.Close();

                    query.CommandText = "SELECT LoanId, LoanTypeID FROM Loan";
                    results = query.ExecuteReader();

                    while (results.Read())
                    {
                        int LoanID = results.GetInt32(results.GetOrdinal("LoanId"));
                        int LoanTypeID = results.GetInt32(results.GetOrdinal("LoanTypeID"));
                        Loans.Add(LoanID, LoanTypeID);
                    }

                    results.Close();

                    query.CommandText = "SELECT a.LoanId, a.StatusCode, a.StatusSequence, a.StatusDate "
                                                            + "FROM LoanStatus a "
                                                            + "LEFT OUTER JOIN LoanStatus b "
                                                                + "ON a.LoanId = b.LoanId AND a.StatusSequence < b.StatusSequence "
                                                           + "WHERE b.LoanId IS NULL; ";
                    results = query.ExecuteReader();

                    while (results.Read())
                    {
                        DateTime StatusDate = results.GetDateTime(results.GetOrdinal("StatusDate"));
                        int StatusCode = results.GetInt32(results.GetOrdinal("StatusCode"));
                        int LoanId = results.GetInt32(results.GetOrdinal("LoanId"));

                        if (Loans.TryGetValue(LoanId, out var LoanTypeID))
                        {
                            if (LoanTypeCategories.TryGetValue(LoanTypeID, out var LoanCategory))
                            {
                                if (((type == LoanType.BOTH || type == LoanType.PRE_CLOSING) && preCloseStatusCodes.Contains(StatusCode) && LoanCategory == 1)
                                        || ((type == LoanType.BOTH || type == LoanType.POST_CLOSING) && postCloseStatusCodes.Contains(StatusCode) && LoanCategory == 2)) {
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
                    }
                }
            }

            

            var JsonObject = from statusCode in StatusCodes.Keys select new { StatusCode = statusCode, Date = StatusDates[statusCode].ToString("yyyy-MM-dd"), Count = StatusCodes[statusCode] };
            return new JsonResult(JsonObject);
        }

 

        /*        // GET api/<PreClosingLoans>/5
                [HttpGet("{id}")]
                public string Get(int id)
                {
                    return "value";
                }

                // POST api/<PreClosingLoans>
                [HttpPost]
                public void Post([FromBody] string value)
                {
                }

                // PUT api/<PreClosingLoans>/5
                [HttpPut("{id}")]
                public void Put(int id, [FromBody] string value)
                {
                }

                // DELETE api/<PreClosingLoans>/5
                [HttpDelete("{id}")]
                public void Delete(int id)
                {
                }*/
    }
}
