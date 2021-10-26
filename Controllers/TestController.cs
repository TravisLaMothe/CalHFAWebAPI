using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            var StatusCodes = new Dictionary<int, int>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand query = new SqlCommand("SELECT LoanId, MAX(StatusCode) AS StatusCode, MAX(StatusSequence) FROM LoanStatus GROUP BY LoanId", connection))
                {
                    SqlDataReader results = query.ExecuteReader();

                    while (results.Read())
                    {
                        int StatusCode = results.GetInt32(results.GetOrdinal("StatusCode"));

                        switch(StatusCode)
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
                                break;
                        }
                    }
                }
            }

            var JsonObject = from statusCode in StatusCodes.Keys select new { StatusCode = statusCode, Count = StatusCodes[statusCode] };
            return new JsonResult(JsonObject);
        }
    }
}
