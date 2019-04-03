using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme_Insurance.Data_Access_Layer
{
    class ConnectionManager
    {
        /* Establishing connection between the application and database
         * Instantiating SqlConnection object */
        public static SqlConnection DatabaseConnection()
        {
            string connection = "Data Source=DESKTOP-A64E115\\SQLEXPRESS;Initial Catalog=Acme;User ID=sa;Password=sqlexpress";
            SqlConnection conn = new SqlConnection(connection);
            return conn;
        }
    }
}
