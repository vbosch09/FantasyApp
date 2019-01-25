using System.Data.SqlClient;

namespace Fantasy.Common.Lib
{
    public static class DatabaseHelper
    {
        public static SqlConnection CreateSqlConnection()
        {
            //TODO -- How to secure the connection string
            SqlConnection oSql = new SqlConnection();
            oSql.ConnectionString = GetSqlConnectionString();
            oSql.Open();
            return oSql;
        }


        static private string GetSqlConnectionString()
        {
            // Prepare the connection string to Azure SQL Database.  
            var sqlConnectionSB = new SqlConnectionStringBuilder();

            // Change these values to your values.  
            sqlConnectionSB.DataSource = "tcp:fantasy01.database.windows.net,1433"; //["Server"]  
            sqlConnectionSB.InitialCatalog = "FantasyFootball"; //["Database"]  

            sqlConnectionSB.UserID = "vbosch23";  // "@yourservername"  as suffix sometimes.  
            sqlConnectionSB.Password = "Bu11d0gs2018";
            sqlConnectionSB.IntegratedSecurity = false;

            // Adjust these values if you like. (ADO.NET 4.5.1 or later.)  
            sqlConnectionSB.ConnectRetryCount = 3;
            sqlConnectionSB.ConnectRetryInterval = 10;  // Seconds.  

            // Leave these values as they are.  
            sqlConnectionSB.IntegratedSecurity = false;
            sqlConnectionSB.Encrypt = true;
            sqlConnectionSB.ConnectTimeout = 30;

            return sqlConnectionSB.ToString();
        }
    }
}
