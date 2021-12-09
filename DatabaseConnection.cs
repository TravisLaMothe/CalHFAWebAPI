using CalHFAWebAPI.Constants;
using MySqlConnector;
using System;
using System.Collections.Generic;

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
            String connectionURL =  "server=" + DatabaseConstants.DATABASE_IP + ";" +
                                    "port=" + DatabaseConstants.DATABASE_PORT + ";" +
                                    "database=" + DatabaseConstants.DATABASE_SCHEMA + ";" +
                                    "user=" + DatabaseConstants.DATABASE_USERNAME + ";" +
                                    "password=" + DatabaseConstants.DATABASE_PASSWORD + "";

            var connection = new MySqlConnection(connectionURL);
           
            connection.Open();
            return connection;
        }

        public static void AddArrayParameters<T>(MySqlCommand cmd, string paramNameRoot, IEnumerable<T> values, MySqlDbType? dbType = null, int? size = null)
        {
            var parameterNames = new List<string>();
            var paramNumber = 1;
            foreach (var value in values)
            {
                var paramName = string.Format("@{0}{1}", paramNameRoot, paramNumber++);
                parameterNames.Add(paramName);
                MySqlParameter p = new MySqlParameter(paramName, value);
                if (dbType.HasValue)
                    p.MySqlDbType = dbType.Value;
                if (size.HasValue)
                    p.Size = size.Value;
                cmd.Parameters.Add(p);
            }

            cmd.CommandText = cmd.CommandText.Replace("{" + paramNameRoot + "}", string.Join(",", parameterNames));
        }
    }
}
