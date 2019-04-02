using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_OC
{
    public partial class frmReturnBook : Form
    {
        public frmReturnBook()
        {
            InitializeComponent();
        }

        private void frmReturnBook_Load(object sender, EventArgs e)
        {
            DataTable issues = ConnectionManager.GetTable("select * from BookIssue");

            foreach (DataRow book in issues.Rows)
            {
                cbBookID.Items.Add(book["bookID"].ToString());
                cbStudentID.Items.Add(book["studentID"].ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int bookID;
            if (!int.TryParse(cbBookID.Text, out bookID))
            {
                MessageBox.Show("Book ID must be an integer", "ERROR", MessageBoxButtons.OK);
                cbBookID.Focus();
                return;
            }
            else if (bookID < 1)
            {
                MessageBox.Show("Book ID must be a positive number");
                cbBookID.Focus();
                return;
            }
            int studentID;
            if (!int.TryParse(cbStudentID.Text, out studentID))
            {
                MessageBox.Show("Student ID must be an integer", "ERROR", MessageBoxButtons.OK);
                cbStudentID.Focus();
                return;
            }
            else if (studentID < 1)
            {
                MessageBox.Show("Student ID must be a positive number");
                cbStudentID.Focus();
                return;
            }
            DataTable books = ConnectionManager.GetTable("select * from BookIssue where bookID = "
                +bookID+ " and studentID = " +studentID);
            if (books.Rows.Count == 0)
            {
                MessageBox.Show("Book ID and student ID do not match any currently issued books");
                cbBookID.Focus();
                return;
            }
            if (DateTime.Parse(books.Rows[0]["issueDate"].ToString()) > dtpReturnDate.Value.Date)
            {
                MessageBox.Show("Return date cannot be before issue date");
                dtpReturnDate.Focus();
                return;
            }

            ReturnBook book = new ReturnBook();
            book.BookID = bookID;
            book.StudentID = studentID;
            book.LibrarianID = int.Parse(Environment.GetEnvironmentVariable("librarianID"));
            book.ReturnDate = dtpReturnDate.Value.Date;
            if (book.ReturnDate > DateTime.Parse(books.Rows[0]["returnDate"].ToString()))
            {
                book.Late = true;
                TimeSpan days = book.ReturnDate.Date - DateTime.Parse(books.Rows[0]["returnDate"].ToString());
                MessageBox.Show("The book you are returning was " + days.Days + " days overdue");
            }
            if (book.Return() != 0)
            {
                book.updateBookQtyOnReturn();
                MessageBox.Show("Book returned successfully");
                cbBookID.Text = "";
                cbStudentID.Text = "";
                cbBookID.Items.Clear();
                cbStudentID.Items.Clear();
                DataTable issues = ConnectionManager.GetTable("select * from BookIssue");
                foreach (DataRow issue in issues.Rows)
                {
                    cbBookID.Items.Add(issue["bookID"].ToString());
                    cbStudentID.Items.Add(issue["studentID"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Failed to return book. Please check details and try again");
                cbBookID.Focus();
            }
        }
    }
}
