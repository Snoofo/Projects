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
    public partial class frmCategoriesAdd : Form
    {
        public frmCategoriesAdd()
        {
            InitializeComponent();
        }

        private void frmCategoriesAdd_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.selectedCategoryID == 0)
            {
                btnAdd.Text = "&Add";
            }
            else
            {
                txtCategoryID.Text = GlobalVariables.selectedCategoryID.ToString();
                btnAdd.Text = "&Update";

                SqlConnection conn = ConnectionManager.DatabaseConnection();
                SqlDataReader rdr = null;

                try
                {
                    conn.Open();

                    // Poplulate category name field
                    string selectQuery = "SELECT Category FROM Categories WHERE CategoryID = " +
                        txtCategoryID.Text;
                    SqlCommand cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();

                    txtCategoryName.Text = (rdr["Category"].ToString());

                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Unable to connect to database: \n\n" + ex.ToString());
                }

                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();
            int categoryID = GlobalVariables.selectedCategoryID;

            // check for empty fields
            if (string.IsNullOrEmpty(txtCategoryName.Text.Trim()))
            {
                MessageBox.Show("Please enter a Category Name");
                return;
            }

            SqlConnection conn = ConnectionManager.DatabaseConnection();

            try
            {
                conn.Open();
                SqlCommand cmd = null;

                if (GlobalVariables.selectedCategoryID == 0)
                {
                    // check if category exists with stored procedure
                    string existsQuery = "DECLARE @RecordCount int EXEC dbo.sp_Categories_ExistsCategory "
                        + txtCategoryName.Text.Trim() + ", @RecordCount output SELECT @RecordCount AS RC";

                    SqlDataReader rdr = null;
                    cmd = new SqlCommand(existsQuery, conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();

                    if (int.Parse(rdr["RC"].ToString()) > 0)
                    {
                        MessageBox.Show("Category already exists");
                    }

                    else
                    {
                        // create category with stored procedure
                        rdr.Close();
                        string selectQuery = "DECLARE @NewCategoryID int EXEC dbo.sp_Categories_CreateCategory "
                            + txtCategoryName.Text.Trim() + ", @NewCategoryID output";

                        cmd.CommandText = selectQuery;
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        MessageBox.Show("Category " + categoryName + " was created");
                        this.Close();
                    }

                    if (rdr != null)
                    {
                        rdr.Close();
                    }

                    conn.Close();
                }

                else
                {
                    // update category with stored procedure
                    string selectQuery = "EXEC dbo.sp_Categories_UpdateCategory " + categoryID
                        + ", " + categoryName;

                    cmd = new SqlCommand(selectQuery, conn);
                    cmd.Transaction = conn.BeginTransaction();
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();

                    MessageBox.Show("Category " + categoryName + " was updated successfully");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to database:\n\n" + ex.ToString());
            }
        }
    }
}
