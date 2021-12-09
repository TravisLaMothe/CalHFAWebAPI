using CalHFAWebAPI.Constants;
using MySqlConnector;
using System;
using System.Collections.Generic;

namespace CalHFAWebAPI.Helpers
{
    public class MySQLConnection
    {
        /// <summary>
        ///     A global method for ease of access to the database.
        /// </summary>
        /// <returns>
        ///     An instance of the <see cref="MySqlConnection"/> class with an open connection to the database ready to use.
        /// </returns>
        /// <exception cref="MySqlException">
        ///     Unable to open a valid MySql Connection to the database.
        /// </exception>
        public static MySqlConnection GetConnection()
        {
            String connectionURL =  "server=" + DatabaseConstants.MYSQL_HOST_NAME + ";" +
                                    "port=" + DatabaseConstants.MYSQL_PORT + ";" +
                                    "database=" + DatabaseConstants.MYSQL_SCHEMA + ";" +
                                    "user=" + DatabaseConstants.MYSQL_USERNAME + ";" +
                                    "password=" + DatabaseConstants.MYSQL_PASSWORD + "";

            var connection = new MySqlConnection(connectionURL);
           
            connection.Open();
            return connection;
        }
    }
}
