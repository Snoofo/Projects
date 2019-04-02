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
    public partial class frmIssueBook : Form
    {
        public frmIssueBook()
        {
            InitializeComponent();
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            if (txtBookID.Text == "" || txtStudentID.Text == "")
            {
                btnSubmit.Enabled = false;
            }
            else
            {
                btnSubmit.Enabled = true;
            }
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            if (txtBookID.Text == "" || txtStudentID.Text == "")
            {
                btnSubmit.Enabled = false;
            }
            else
            {
                btnSubmit.Enabled = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int bookID;
            if (!int.TryParse(txtBookID.Text, out bookID))
            {
                MessageBox.Show("Book ID must be an integer", "ERROR", MessageBoxButtons.OK);
                return;
            }
            else if (bookID < 1)
            {
                MessageBox.Show("Book ID must be a positive number");
                txtBookID.Focus();
                return;
            }
            int studentID;
            if (!int.TryParse(txtStudentID.Text, out studentID))
            {
                MessageBox.Show("Student ID must be an integer", "ERROR", MessageBoxButtons.OK);
                return;
            }
            else if (studentID < 1)
            {
                MessageBox.Show("Student ID must be a positive number");
                txtStudentID.Focus();
                return;
            }

            DataTable books = ConnectionManager.GetTable("select * from Book where bookID = "
                + bookID);
            if (books.Rows.Count == 0)
            {
                MessageBox.Show("No book was found matching book ID " + bookID);
                return;
            }
            DataTable students = ConnectionManager.GetTable("select * from Student where studentID = "
                + studentID);
            if (students.Rows.Count == 0)
            {
                MessageBox.Show("No student was found matching student ID " + studentID);
                return;
            }

            if (int.Parse(books.Rows[0]["noOfAvailableBooks"].ToString()) < 1)
            {
                MessageBox.Show("No copies of " + books.Rows[0]["title"].ToString() + "are available");
            }
            else
            {
                IssueBook book = new IssueBook();
                book.BookID = bookID;
                book.StudentID = studentID;
                book.LibrarianID = int.Parse(Environment.GetEnvironmentVariable("librarianID"));
                book.IssueDate = DateTime.Now;
                book.ReturnDate = book.IssueDate.Add(new TimeSpan(14, 0, 0, 0));
                if (book.Issue() != 0)
                {
                    book.updateBookQtyOnIssue();
                    MessageBox.Show("Book issued successfully");
                    txtBookID.Text = "";
                    txtStudentID.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to issue book. Please check details and try again");
                    txtBookID.Focus();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
