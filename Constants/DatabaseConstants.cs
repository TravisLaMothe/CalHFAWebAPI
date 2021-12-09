using System;

namespace CalHFAWebAPI.Constants
{
    public static class DatabaseConstants
    {
        public const bool USE_MYSQL = true;

        /*
         * Project constants for access to the SQL Server Database hosted by CalHFA. For use in production.
         */
        public const String SQLSERVER_HOST_NAME = "calhfawebapi.database.windows.net";
        public const String SQLSERVER_DATABASE_NAME = "CSC131";
        public const String SQLSERVER_ACCESS_TYPE = "tcp";
        public const String SQLSERVER_PORT = "1433";
        public const String SQLSERVER_USER = "dummyreader";
        public const String SQLSERVER_PASS = "Dummytest123";


        /*
         * Project constants for access to the test MySQL Database provided by team Better Dragon. Data on test database is consistent with dummy data sent by the client.
         */
        public const String MYSQL_HOST_NAME = "csc131project.mysql.database.azure.com";
        public const String MYSQL_PORT = "3306";
        public const String MYSQL_SCHEMA = "CSC131";
        public const String MYSQL_USERNAME = "dummyreader";
        public const String MYSQL_PASSWORD = "Dummytest123";
    }
}
