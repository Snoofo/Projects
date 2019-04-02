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
    public partial class frmReserveBook : Form
    {
        public frmReserveBook()
        {
            InitializeComponent();
        }

        private void frmReserveBook_Load(object sender, EventArgs e)
        {
            DataTable issuedBooks = ConnectionManager.GetTable("select * from BookIssue JOIN Book ON "
                + "BookIssue.bookID = Book.bookID");
            if (issuedBooks.Rows.Count == 0)
            {
                MessageBox.Show("There are no books currently issued to be reserved");
                return;
            }
            foreach (DataRow book in issuedBooks.Rows)
            {
                ListViewItem lvi = new ListViewItem(book["title"].ToString());
                lvi.SubItems.Add(((DateTime)book["returnDate"]).ToString());
                lvi.SubItems.Add(book["bookID"].ToString());
                lvIssuesList.Items.Add(lvi);
            }

            DataTable students = ConnectionManager.GetTable("select * from Student");
            foreach (DataRow student in students.Rows)
            {
                cbStudentID.Items.Add(student["studentID"].ToString());
            }
        }

        private void btnReserveBook_Click(object sender, EventArgs e)
        {
            DateTime rDate = Convert.ToDateTime(lvIssuesList.SelectedItems[0].SubItems[1].Text);
            MessageBox.Show(dtpReserveDate.Value.Date.ToString());
            ReserveBook reserve = new ReserveBook();
            //if (dtpReserveDate.Value.Date < date)
            //{
            //    MessageBox.Show("The book will still be loaned at this date.\n"
            //      + "Please select a date after the due date");
            //}
            if ((reserve.StudentID = int.Parse(cbStudentID.Text)) == 0)
            {
                MessageBox.Show("Student ID must be an integer");
                cbStudentID.Focus();
                return;
            }
            else if (reserve.StudentID  < 1)
            {
                MessageBox.Show("Student ID must be a positive number");
                cbStudentID.Focus();
                return;
            }
            reserve.BookID = int.Parse(lvIssuesList.SelectedItems[0].SubItems[2].Text);
            reserve.LibrarianID = int.Parse(Environment.GetEnvironmentVariable("librarianID"));
            reserve.ReturnDate = dtpReserveDate.Value.Date;
            string resDate = reserve.ReserveDate.ToString("MM-DD-YY");
            MessageBox.Show(resDate);
            if ((reserve.Reserve()) != 0)
            {
                MessageBox.Show("Book successfully reserved");
            }
            else
            {
                MessageBox.Show("Book was not reserved, please check details and try again");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvIssuesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvIssuesList.SelectedItems.Count == 0 || cbStudentID.Text == "")
            {
                btnReserveBook.Enabled = false;
            }
            else
            {
                btnReserveBook.Enabled = true;
            }
        }

        private void cbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvIssuesList.SelectedItems.Count == 0 || cbStudentID.Text == "")
            {
                btnReserveBook.Enabled = false;
            }
            else
            {
                btnReserveBook.Enabled = true;
            }
        }

        private void cbStudentID_TextUpdate(object sender, EventArgs e)
        {
            if (lvIssuesList.SelectedItems.Count == 0 || cbStudentID.Text == "")
            {
                btnReserveBook.Enabled = false;
            }
            else
            {
                btnReserveBook.Enabled = true;
            }
        }
    }
}
