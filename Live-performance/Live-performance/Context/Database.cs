using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_performance.Context
{
    class Database
    {
        public static SqlConnection Connection
        {
            get
            {
                SqlConnection connection = new SqlConnection(connectionstring);
                connection.Open();
                return connection;
            }
         }
        private static string connectionstring = @"Server=mssql.fhict.local;Database=dbi356103;User Id=dbi356103;Password=Password;";
    }
}
