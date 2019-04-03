using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acme_Insurance.Presentation_Layer;
using System.Data.SqlClient;
using Acme_Insurance.Data_Access_Layer;
using Acme_Insurance.Business_Logic_Layer;

namespace Acme_Insurance.Presentation_Layer
{
    public partial class frmCategoriesView : Form
    {
        public frmCategoriesView()
        {
            InitializeComponent();
        }

        // populates list view with categories details
        private void DisplayCategories()
        {
            string selectQuery;

            selectQuery = "SELECT * FROM Categories";

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Category category = new Category(int.Parse(rdr["CategoryID"].ToString()), rdr["Category"].ToString());
                    ListViewItem lvi = new ListViewItem(category.CategoryID.ToString());
                    lvi.SubItems.Add(category.CategoryName.ToString());
                    lvCategories.Items.Add(lvi);
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to database\n" + ex.ToString());
            }
        }

        private void frmCategoriesView_Load(object sender, EventArgs e)
        {
            DisplayCategories();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalVariables.selectedCategoryID = 0;
            frmCategoriesAdd editForm = new frmCategoriesAdd();
            editForm.ShowDialog();
            // repopulate list view with updated category details
            lvCategories.Items.Clear();
            DisplayCategories();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvCategories.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Category to update");
                return;
            }
            GlobalVariables.selectedCategoryID = int.Parse(lvCategories.SelectedItems[0].Text);
            frmCategoriesAdd editForm = new frmCategoriesAdd();
            editForm.ShowDialog();
            // repopulate list view with updated category details
            lvCategories.Items.Clear();
            DisplayCategories();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmCategoriesSearch searchForm = new frmCategoriesSearch();
            searchForm.ShowDialog();
        }

        // deletes a category
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // check for selected index
            if (lvCategories.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Category to delete");
                return;
            }

            string categoryID = lvCategories.SelectedItems[0].Text;

            // display confirm dialog
            DialogResult result = MessageBox.Show("Are you sure you want to delete category " + categoryID ,"Delete Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // check category can be deleted with stored procedure
                string allowDelete = "DECLARE @RecordCount int EXEC dbo.sp_Categories_AllowDeleteCategory "
                    + categoryID + ", @RecordCount output SELECT @RecordCount AS RC";
                SqlConnection conn = ConnectionManager.DatabaseConnection();
                SqlDataReader rdr = null;

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(allowDelete, conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();

                    if (int.Parse(rdr["RC"].ToString()) == 0)
                    {
                        // deletes category
                        rdr.Close();
                        cmd.CommandText = "EXEC dbo.sp_Categories_DeleteCategory " + categoryID;
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        MessageBox.Show("Sucessfully deleted category " + categoryID);
                    }
                    else
                    {
                        MessageBox.Show("Category is in use by a Customer it cannot be deleted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not delete category " + categoryID + "\n" + ex.ToString());
                }

                // repopulate list view with updated category details
                lvCategories.Items.Clear();
                DisplayCategories();
            }

        }
    }
}
