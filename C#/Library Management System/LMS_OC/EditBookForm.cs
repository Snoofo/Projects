using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LMS_OC
{
    public partial class EditBookForm : Form
    {
        public EditBookForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBookID .Text == "")
            {
                MessageBox.Show("Please provide book ID to search.");
                txtBookID.Focus();
                return;
            }
            try
            {
                double.Parse(txtBookID .Text);
            }
            catch
            {
                MessageBox.Show("Accepts only integer number as Book ID.");
                txtBookID.Text = "";
                txtBookID.Focus();
                return;
            }
            DataTable bookDT=ConnectionManager.GetTable("select * from Book where bookID="+txtBookID.Text +"");
            if (bookDT.Rows.Count == 0)
            {
                ClearTextBoxes();
                MessageBox.Show("Book with book ID " + txtBookID.Text + "doesn't exist");              

            }
            else
            {
                MessageBox.Show("Book found successfully.");
                txtBookTitle.Text = bookDT.Rows[0]["title"].ToString();
                txtCopies.Text = bookDT.Rows[0]["noOfAvailableBooks"].ToString();
                txtISBN.Text = bookDT.Rows[0]["ISBN"].ToString();
                txtPrice.Text = bookDT.Rows[0]["price"].ToString();
                txtRackNo.Text = bookDT.Rows[0]["rackNo"].ToString();
                lstAuthor.SelectedValue = bookDT.Rows[0]["authorID"].ToString();
                btnEdit.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() == false) return;
            Book bookToEdit = new Book();
            bookToEdit.BookID =int.Parse( txtBookID.Text);
            bookToEdit.BookTitle = txtBookTitle.Text;
            bookToEdit.BookAuthorID = int.Parse(lstAuthor.SelectedValue.ToString());
            bookToEdit.BookPrice =double.Parse( txtPrice.Text);
            bookToEdit.RackNumber = txtRackNo.Text;
            bookToEdit.AvailableBooks =int.Parse( txtCopies.Text);
            bookToEdit.LibrarianID =int.Parse(System.Environment.GetEnvironmentVariable("librarianID"));
            bookToEdit.BookISBN = txtISBN.Text;
            int recordEdited=bookToEdit.EditBook();
            if (recordEdited == 0)
            {
                MessageBox.Show("Update Operation failed. Check the values provided and try again.");
            }
            else
            {
                MessageBox.Show("Book updated successfully.");
                ClearTextBoxes();
            }
        }
        private void ClearTextBoxes()
        {
            txtBookID.Text = "";
            txtBookTitle.Text = "";
            txtCopies.Text = "";
            txtISBN.Text = "";
            txtPrice.Text = "";
            txtRackNo.Text = "";
            txtBookID.Focus();
            btnEdit.Enabled = false;
        }
        private bool ValidateInputs()
        {
            if (txtISBN.Text == "")
            {
                MessageBox.Show("Book ISBN can't be null.");
                txtISBN.Focus();
                return false;
            }
            if (txtBookTitle.Text == "")
            {
                MessageBox.Show("Book title can't be null.");
                txtBookTitle.Focus();
                return false;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Book price can't be null.");
                txtPrice.Focus();
                return false;
            }
            try
            {
                double.Parse(txtPrice.Text);
            }
            catch
            {
                MessageBox.Show("Accepts only numeric data as price.");
                txtPrice.Text = "";
                txtPrice.Focus();
                return false;
            }
            if (txtCopies.Text == "")
            {
                MessageBox.Show("Please enter number of copies available for this new book.");
                txtCopies.Focus();
                return false;
            }
            try
            {
                int.Parse(txtCopies.Text);
            }
            catch
            {
                MessageBox.Show("Accepts only integer number for available copies.");
                txtCopies.Text = "";
                txtCopies.Focus();
                return false;
            }
            return true;

        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            DataTable authorTableData = ConnectionManager.GetTable("select * from Author");
            lstAuthor.DataSource = authorTableData;
            lstAuthor.DisplayMember = "authorName";
            lstAuthor.ValueMember = "authorID";
            txtBookID.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
