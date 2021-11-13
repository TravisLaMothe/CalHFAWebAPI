using MySqlConnector;
using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CalHFAWebAPI
{
    public class DatabaseConnection
    {


        public static readonly String DB_DATABASE_NAME = "CSC131";
        public static readonly String DB_HOST_NAME = "csc131project.mysql.database.azure.com";
        public static readonly String DB_ACCESS_TYPE = "tcp";
        public static readonly int DB_PORT = 3306;
        public static readonly String DB_DATA_SOURCE = "" + DB_ACCESS_TYPE + ":" + DB_HOST_NAME + ", " + DB_PORT;
        public static readonly String DB_USER = "dummyreader";
        public static readonly String DB_PASS = "Dummytest123";

        public static readonly String DB_CONNECTION_STRING =
            new SqlConnectionStringBuilder()
            {
                DataSource = DB_DATA_SOURCE,
                InitialCatalog = DB_DATABASE_NAME,
                UserID = DB_USER,
                Password = DB_PASS/*,
                MultipleActiveResultSets = true*/
            }.ConnectionString;

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
