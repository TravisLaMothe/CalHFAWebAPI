using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusCodesController : ControllerBase
    {

        [HttpGet]
        public JsonResult Get()
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand query = new SqlCommand("SELECT StatusCode, Description, BusinessUnit, NotesAndAssumptions, ConversationCategoryID FROM StatusCode", connection))
                {

                    var results = query.ExecuteReader();

                    table.Load(results);
                }
            }

            return new JsonResult(table);
        }

        [HttpGet("{id:int}")]
        public JsonResult Get([FromQuery]int statusCode)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand query = new SqlCommand("SELECT StatusCode, Description, BusinessUnit, NotesAndAssumptions, ConversationCategoryID FROM StatusCode WHERE StatusCode = @StatusCode", connection))
                {
                    query.Parameters.AddWithValue("@StatusCode", statusCode);
                    var results = query.ExecuteReader();

                    table.Load(results);
                }
            }

            return new JsonResult(table);
        }
    }
}
