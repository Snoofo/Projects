using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_OC
{
    class ReserveBook : ReturnBook
    {
        private DateTime reserveDate;

        public ReserveBook() { }

        public ReserveBook(int studentID, int bookID, DateTime reserveDate)
        {
            StudentID = studentID;
            BookID = bookID;
            ReserveDate = reserveDate;
        }

        public DateTime ReserveDate
        {
            get { return reserveDate; }
            set { reserveDate = value; }
        }

        internal int Reserve()
        {
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            string rDate = ReserveDate.Month + "-" + ReserveDate.Day + "-" + ReserveDate.Year;
            cmd.CommandText = "insert into BookReserve (studentID, reserveDate, librarianID,"
                + " bookID) values (" + StudentID + ", '" + rDate + "', " + LibrarianID + ", "
                + BookID + ")";
            cmd.Connection = con;
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
            return status;
        }
    }
}
