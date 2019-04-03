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
    public partial class frmProductTypesAdd : Form
    {
        public frmProductTypesAdd()
        {
            InitializeComponent();
        }

        private void frmProductTypesAdd_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.selectedProductType == 0)
            {
                btnAdd.Text = "&Add";
            }
            else
            {
                // populate input field with selected product type
                txtProductTypeID.Text = GlobalVariables.selectedProductType.ToString();
                btnAdd.Text = "&Update";

                SqlConnection conn = ConnectionManager.DatabaseConnection();
                SqlDataReader rdr = null;

                try
                {
                    conn.Open();

                    // Poplulate category name field
                    string selectQuery = "SELECT ProductType FROM ProductTypes WHERE ProductTypeID = " +
                        txtProductTypeID.Text;
                    SqlCommand cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();

                    txtProductTypeName.Text = (rdr["ProductType"].ToString());

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
            // check input field is valid
            if (string.IsNullOrEmpty(txtProductTypeName.Text))
            {
                MessageBox.Show("Please enter a product type name");
                return;
            }

            SqlConnection conn = ConnectionManager.DatabaseConnection();

            try
            {
                conn.Open();
                SqlCommand cmd = null;

                if (GlobalVariables.selectedProductType == 0)
                {
                    // check product type exists with stored procedure
                    string existsQuery = "DECLARE @RecordCount int EXEC dbo.sp_ProductTypes_ExistsProductType " +
                        txtProductTypeName.Text + ", @RecordCount output SELECT @RecordCount AS RC";

                    SqlDataReader rdr = null;
                    cmd = new SqlCommand(existsQuery, conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();

                    if (int.Parse(rdr["RC"].ToString()) > 0)
                    {
                        MessageBox.Show("Product already exists");
                    }

                    else
                    {
                        rdr.Close();

                        // create product with stored procedure
                        string selectQuery = "DECLARE @NewProductTypeID int EXEC dbo.sp_ProductTypes_CreateProductType " +
                            txtProductTypeName.Text + ", @NewProductTypeID output";

                        cmd.CommandText = selectQuery;
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        MessageBox.Show("Product " + txtProductTypeName.Text + " was created");
                        this.Close();
                    }

                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                }

                else
                {
                    // updates product with stored procedure
                    string selectQuery = "EXEC dbo.sp_ProductTypes_UpdateProductType " + txtProductTypeID.Text +
                        ", " + txtProductTypeName.Text;

                    cmd = new SqlCommand(selectQuery, conn);
                    cmd.Transaction = conn.BeginTransaction();
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();

                    MessageBox.Show("Product " + txtProductTypeName.Text + " was updated successfully");
                    this.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to database:\n\n" + ex.ToString());
            }

            conn.Close();
        }
    }
}
