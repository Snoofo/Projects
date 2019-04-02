using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_OC
{
    class IssueBook : Book
    {
        int studentID;
        DateTime issueDate;
        DateTime returnDate;

        public IssueBook() { }

        public IssueBook(int bookID, int studentID, int librarianID, DateTime issueDate, DateTime returnDate)
        {
            BookID = bookID;
            StudentID = studentID;
            LibrarianID = librarianID;
            IssueDate = issueDate;
            ReturnDate = returnDate;
        }

        public int StudentID
        {
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;
            }
        }

        public DateTime IssueDate
        {
            get
            {
                return issueDate;
            }
            set
            {
                issueDate = value;
            }
        }

        public DateTime ReturnDate
        {
            get
            {
                return returnDate;
            }
            set
            {
                returnDate = value;
            }
        }

        internal int Issue()
        {
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            string rDate = ReturnDate.Month + "-" + ReturnDate.Day + "-" + ReturnDate.Year;
            string iDate = IssueDate.Month + "-" + IssueDate.Day + "-" + IssueDate.Year;
            cmd.CommandText = "insert into BookIssue (studentID, issueDate, returnDate, librarianID, bookID)"
                + " values(" +StudentID+ ", '" +iDate+ "', '"
                + rDate + "', " +LibrarianID+ ", " +BookID+ ")";
            cmd.Connection = con;
            con.Open();
            int status = cmd.ExecuteNonQuery();
            con.Close();
            return status;

        }
    }
}
