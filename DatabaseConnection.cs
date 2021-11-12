using System;
using System.Data.SqlClient;

namespace WebApplication3
{
    public class DatabaseConnection
    {


        public static readonly String DB_DATABASE_NAME = "CSC131";
        public static readonly String DB_HOST_NAME = "calhfawebapi.database.windows.net";
        public static readonly String DB_ACCESS_TYPE = "tcp";
        public static readonly int DB_PORT = 1433;
        public static readonly String DB_DATA_SOURCE = "" + DB_ACCESS_TYPE + ":" + DB_HOST_NAME + ", " + DB_PORT;
        public static readonly String DB_USER = "dummyreader";
        public static readonly String DB_PASS = "Dummytest123";

        public static readonly String DB_CONNECTION_STRING =
            new SqlConnectionStringBuilder()
            {
                DataSource = DB_DATA_SOURCE,
                InitialCatalog = DB_DATABASE_NAME,
                UserID = DB_USER,
                Password = DB_PASS,
                MultipleActiveResultSets = true
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
        public static SqlConnection GetConnection()
        {
            var connection = new SqlConnection(DB_CONNECTION_STRING);
            connection.Open();
            return connection;
        }
    }
}
