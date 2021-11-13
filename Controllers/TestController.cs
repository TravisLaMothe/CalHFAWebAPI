using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

namespace CalHFAWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public JsonResult Get()
        {
            var StatusCodes = new SortedDictionary<int, int>();
            var StatusDates = new Dictionary<int, DateTime>();
            var LoanTypeCategories = new Dictionary<int, int>();
            var Loans = new Dictionary<int, int>();

            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                // Stack categories
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


                        bool continueLoan = false;
                        if (Loans.TryGetValue(LoanId, out var LoanTypeID))
                        {
                            if (LoanTypeCategories.TryGetValue(LoanTypeID, out var LoanCategory))
                            {
                                if ((StatusCode == 510 || StatusCode == 522) && LoanCategory == 2)
                                    continueLoan = true;
                                if ((StatusCode == 410 || StatusCode == 422) && LoanCategory == 1)
                                    continueLoan = true;
                            }
                        }

                        if (continueLoan)
                        {

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

                            switch (StatusCode)
                            {
                                case 410:
                                case 422:
                                case 510:
                                case 522:
                                    if (StatusCodes.ContainsKey(StatusCode))
                                    {
                                        StatusCodes.TryGetValue(StatusCode, out var currentCount);
                                        StatusCodes[StatusCode] = currentCount + 1;
                                    }
                                    else
                                    {
                                        StatusCodes.Add(StatusCode, 1);
                                    }
                                    break;
                                default:
                                    Debug.WriteLine("Test????");
                                    break;
                            }
                        }
                    }
                }
            }

            var JsonObject = from statusCode in StatusCodes.Keys select new { StatusCode = statusCode, Date = StatusDates[statusCode].ToString("yyyy-MM-dd"), Count = StatusCodes[statusCode] };
            return new JsonResult(JsonObject);
        }
    }
}
