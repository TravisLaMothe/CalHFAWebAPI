using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using System.Data;

namespace CalHFAWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusCodesController : ControllerBase
    {
        [HttpGet]
        public JsonResult Get(int statusCode)
        {
            DataTable table = new DataTable();

            using (MySqlConnection connection = DatabaseConnection.GetConnection())
            {
                string command = "SELECT StatusCode, Description, BusinessUnit, NotesAndAssumptions, ConversationCategoryID FROM StatusCode";
                if (statusCode > 0)
                {
                    command += " WHERE StatusCode = @StatusCode";
                }
                using (MySqlCommand query = new MySqlCommand(command, connection))
                {
                    if (statusCode > 0)
                    {
                        query.Parameters.AddWithValue("@StatusCode", statusCode);
                    }

                    var results = query.ExecuteReader();

                    table.Load(results);
                }
            }

            return new JsonResult(table);
        }
    }
}
