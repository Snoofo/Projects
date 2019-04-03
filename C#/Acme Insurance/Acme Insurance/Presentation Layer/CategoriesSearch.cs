using Acme_Insurance.Business_Logic_Layer;
using Acme_Insurance.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acme_Insurance.Presentation_Layer
{
    public partial class frmCategoriesSearch : Form
    {
        public frmCategoriesSearch()
        {
            InitializeComponent();
        }

        // enables corresponding input fields to selected search criteria
        private void rbCategoryID_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCategoryName.Checked)
            {
                txtCategoryName.Enabled = true;
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked)
            {
                txtCategoryName.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlCommand cmd = null;
            SqlDataReader rdr = null;

            try
            {
                conn.Open();

                // search for and display all categories
                if (rbAll.Checked)
                {
                    string selectQuery = "SELECT * FROM Categories";

                    cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();

                    lvSearchResult.Items.Clear();

                    // populate list view with returned category details
                    while (rdr.Read())
                    {
                        Category category = new Category(int.Parse(rdr["CategoryID"].ToString()),
                            rdr["Category"].ToString());
                        ListViewItem lvi = new ListViewItem(category.CategoryID.ToString());
                        lvi.SubItems.Add(category.CategoryName);
                        lvSearchResult.Items.Add(lvi);
                    }

                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                }

                // search for and display categories for category name
                else if (rbCategoryName.Checked)
                {
                    if (string.IsNullOrEmpty(txtCategoryName.Text))
                    {
                        MessageBox.Show("Please enter a category name");
                        return;
                    }

                    string selectQuery = "SELECT * FROM Categories WHERE Category = '"
                        + txtCategoryName.Text + "'";

                    cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();

                    lvSearchResult.Items.Clear();

                    // populate list view with returned category details
                    while (rdr.Read())
                    {
                        Category category = new Category(int.Parse(rdr["CategoryID"].ToString()),
                            rdr["Category"].ToString());
                        ListViewItem lvi = new ListViewItem(category.CategoryID.ToString());
                        lvi.SubItems.Add(category.CategoryName);
                        lvSearchResult.Items.Add(lvi);
                    }

                    if (lvSearchResult.Items.Count == 0)
                    {
                        MessageBox.Show("Nothing found matching " + txtCategoryName.Text);
                    }

                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to database: \n\n" + ex.ToString());
            }
        }
    }
}
