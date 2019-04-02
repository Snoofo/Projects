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
    public partial class frmSearchBook : Form
    {
        public frmSearchBook()
        {
            InitializeComponent();
        }
        private void txtBookTitle_TextChanged(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                btnSearchTitle.Enabled = false;
            }
            else
            {
                btnSearchTitle.Enabled = true;
            }
        }

        private void btnSearchTitle_Click(object sender, EventArgs e)
        {
            DataTable books = ConnectionManager.GetTable("select * from Book JOIN Author ON "
                + "Author.authorID = Book.authorID where Book.title = '" + txtTitle.Text + "'");
            if (books.Rows.Count == 0)
            {
                txtTitle.Text = "";
                MessageBox.Show("No books found with the title " + txtTitle.Text);
            }
            else
            {
                lvResults.Items.Clear();
                for (int count = 0; count < books.Rows.Count; ++count)
                {
                    ListViewItem lvi = new ListViewItem(books.Rows[count]["title"].ToString());
                    lvi.SubItems.Add(books.Rows[count]["title"].ToString());
                    lvi.SubItems.Add(books.Rows[count]["authorName"].ToString());
                    lvi.SubItems.Add(books.Rows[count]["noOfAvailable"].ToString());
                    lvi.SubItems.Add(books.Rows[count]["noOfBorrowed"].ToString());
                    lvi.SubItems.Add(books.Rows[count]["bookID"].ToString());
                    lvi.SubItems.Add(books.Rows[count]["rackNo"].ToString());
                    lvi.SubItems.Add(books.Rows[count]["ISBN"].ToString());
                    lvResults.Items.Add(lvi);
                }
            }
        }

        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            DataTable books = ConnectionManager.GetTable("select * from Book FULL OUTER JOIN Author ON "
                + "Author.authorID = Book.authorID where authorName = '" + cbAuthor.SelectedItem.ToString() + "'");
            if (books.Rows.Count == 0)
            {
                MessageBox.Show("No books found with author " + cbAuthor.Text);
            }
            else
            {
                lvResults.Items.Clear();
                for (int count = 0; count < books.Rows.Count; ++count)
                {
                    ListViewItem lvi = new ListViewItem(books.Rows[count]["title"].ToString());
                    lvi.SubItems.Add(books.Rows[count]["title"].ToString());
                    lvi.SubItems.Add(books.Rows[count]["authorName"].ToString());
                    lvi.SubItems.Add(books.Rows[count]["noOfAvailable"].ToString());
                    lvi.SubItems.Add(books.Rows[count]["noOfBorrowed"].ToString());
                    lvi.SubItems.Add(books.Rows[count]["bookID"].ToString());
                    lvi.SubItems.Add(books.Rows[count]["rackNo"].ToString());
                    lvi.SubItems.Add(books.Rows[count]["ISBN"].ToString());
                    lvResults.Items.Add(lvi);
                }
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                btnSearchTitle.Enabled = false;
            }
            else
            {
                btnSearchTitle.Enabled = true;
            }
        }

        private void frmSearchBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDBDataSet.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.lMSDBDataSet.Author);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}