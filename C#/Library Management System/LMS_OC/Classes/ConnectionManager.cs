using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace LMS_OC
{
    class ConnectionManager
    {
        public static  SqlConnection DBConnection()
        {
           
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\LMSDB.mdf; Integrated Security = True; Connect Timeout = 30");
            return con;
        }
        public static DataTable GetTable(string selectQuery)
        {
            DataTable dt=new DataTable();
            SqlConnection con = DBConnection();
            SqlDataAdapter adp = new SqlDataAdapter(selectQuery,con);
            con.Open();
            adp.Fill(dt);
            con.Close();
            return dt;
        }
       
    }
}
