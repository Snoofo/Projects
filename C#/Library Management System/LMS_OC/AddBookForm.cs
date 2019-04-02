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
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        //Clears textboxes on form to take another entry
        private void ClearTextBoxes()
        {
            txtBookTitle.Text = "";
            txtCopies.Text = "";
            txtISBN.Text = "";
            txtPrice.Text = "";
            txtRackNo.Text = "";
            txtISBN.Focus();
        }
        //Close AddBook form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() == false) return;
            Book newBook = new Book(txtISBN.Text,txtBookTitle.Text,int.Parse(lstAuthor.SelectedValue.ToString()),double.Parse(txtPrice.Text ),
                txtRackNo.Text,int.Parse(txtCopies.Text),0,int.Parse(System.Environment.GetEnvironmentVariable("librarianID")));
                   
            int recordAdded=newBook.AddNewBook();
            if (recordAdded != 0)
            {
                MessageBox.Show("Book inserted successfully.");
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Insertion Operation failed. Check the values provided and try again.");
            }
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            DataTable authorTableData = ConnectionManager.GetTable("select * from Author");
            lstAuthor.DataSource = authorTableData;
            lstAuthor.DisplayMember = "authorName";
            lstAuthor.ValueMember = "authorID";
            txtISBN.Focus();
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


    }
}
