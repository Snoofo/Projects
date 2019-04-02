using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_OC
{
    class ReturnBook : IssueBook
    {
        bool late = false;

        public ReturnBook() { }

        public ReturnBook(int bookID, int studentID, int librarianID, DateTime returnDate, bool isLate)
        {
            BookID = bookID;
            StudentID = studentID;
            LibrarianID = librarianID;
            ReturnDate = returnDate;
            Late = isLate;
        }

        public bool Late
        {
            get { return late; }
            set { late = value; }
        }

        internal int Return()
        {
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            string rDate = ReturnDate.Month + "-" + ReturnDate.Day + "-" + ReturnDate.Year;
            cmd.CommandText = "insert into BookReturn (studentID, returnDate, librarianID,"
                + " bookID) values (" +StudentID+ ", '" +rDate+ "', " +LibrarianID
                + ", " +BookID+ ")";
            cmd.Connection = con;
            con.Open();
            int status = cmd.ExecuteNonQuery();
            if (status == 0)
            {
                return status;
            }
            cmd.CommandText = "delete from BookIssue where bookID = " + BookID;
            status = cmd.ExecuteNonQuery();
            con.Close();
            return status;
        }
    }
}
