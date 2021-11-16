using MySqlConnector;
using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CalHFAWebAPI
{
    public class DatabaseConnection
    {
        /// <summary>
        ///     A global method for ease of access to the database.
        /// </summary>
        /// <returns>
        ///     An instance of the <see cref="SqlConnection"/> class with an open connection to the database ready to use.
        /// </returns>
        /// <exception cref="SqlException">
        ///     Unable to open a valid Sql Connection to the database.
        /// </exception>
        public static MySqlConnection GetConnection()
        {
            var connection = new MySqlConnection("server=csc131project.mysql.database.azure.com;port=3306;database=CSC131;user=dummyreader;password=Dummytest123");
            connection.Open();
            return connection;
        }
    }
}
