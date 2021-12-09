using System;
using System.Data.SqlClient;
using CalHFAWebAPI.Constants;

namespace CalHFAWebAPI.Helpers
{
    public class SQLServerConnection
    {
        private static readonly String DB_CONNECTION_STRING =
            new SqlConnectionStringBuilder()
            {
                DataSource = DatabaseConstants.SQLSERVER_ACCESS_TYPE + ":" + DatabaseConstants.SQLSERVER_HOST_NAME + ", " + DatabaseConstants.SQLSERVER_PORT,
                InitialCatalog = DatabaseConstants.SQLSERVER_DATABASE_NAME,
                UserID = DatabaseConstants.SQLSERVER_USER,
                Password = DatabaseConstants.SQLSERVER_PASS,
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
