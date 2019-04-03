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
    public partial class frmProductsAdd : Form
    {
        public frmProductsAdd()
        {
            InitializeComponent();
        }

        private void frmProductsAdd_Load(object sender, EventArgs e)
        {

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            try
            {
                conn.Open();

                // populates the product type combo box with existing product types
                string selectQuery = "SELECT DISTINCT ProductType, Products.ProductTypeID FROM Products INNER JOIN ProductTypes " +
                    "ON Products.ProductTypeID = ProductTypes.ProductTypeID";
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cbProductType.Items.Add((rdr["ProductType"].ToString()));
                    lbProductTypeID.Items.Add(int.Parse(rdr["ProductTypeID"].ToString()));
                }

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

            if (GlobalVariables.selectedProductID == 0)
            {
                btnAdd.Text = "&Add";
            }
            else
            {
                txtProductID.Text = GlobalVariables.selectedProductID.ToString();
                btnAdd.Text = "&Update";

                try
                {
                    conn.Open();

                    // populates input fields with selected product details
                    string selectQuery = "SELECT DISTINCT ProductType, ProductName, Products.ProductTypeID, YearlyPremium " +
                       "FROM Products INNER JOIN ProductTypes " + "ON Products.ProductID =" + txtProductID.Text;
                    SqlCommand cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();

                    cbProductType.Text = rdr["ProductType"].ToString();
                    txtProductName.Text = rdr["ProductName"].ToString();
                    txtYearlyPremium.Text = (float.Parse(rdr["YearlyPremium"].ToString()).ToString("n2"));
                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Unable to connect to database: \n\n" + ex.ToString());
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check for valid input in all fields
            if (string.IsNullOrEmpty(cbProductType.Text))
            {
                MessageBox.Show("Please select a product type");
                return;
            }

            if (string.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name");
                return;
            }

            double outputD;
            if (!double.TryParse(txtYearlyPremium.Text, out outputD))
            {
                MessageBox.Show("Please enter a numeric value");
                return;
            }

            SqlConnection conn = ConnectionManager.DatabaseConnection();

            try
            {
                conn.Open();
                SqlCommand cmd = null;


                if (GlobalVariables.selectedProductID == 0)
                {
                    // check product exists with stored procedure
                    string existsQuery = "DECLARE @RecordCount int EXEC dbo.sp_Products_ExistsProduct " +
                        (cbProductType.SelectedIndex + 1) + ", " + txtProductName.Text
                        + ", @RecordCount output SELECT @RecordCount AS RC";

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
                        string selectQuery = "DECLARE @NewProductID int EXEC dbo.sp_Products_CreateProduct " +
                           (cbProductType.SelectedIndex + 1) + ", " + txtProductName.Text + ", " +
                           txtYearlyPremium.Text + ", @NewProductID output";

                        cmd.CommandText = selectQuery;
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        MessageBox.Show("Product " + txtProductName.Text + " was created");
                        this.Close();
                    }

                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                }

                else
                {
                    // update product with stored procedure
                    string selectQuery = "EXEC dbo.sp_Products_UpdateProduct " + txtProductID.Text +
                        ", " + lbProductTypeID.Items[cbProductType.SelectedIndex] + ", " + txtProductName.Text + ", " +
                        txtYearlyPremium.Text;

                    cmd = new SqlCommand(selectQuery, conn);
                    cmd.Transaction = conn.BeginTransaction();
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();

                    MessageBox.Show("Product " + txtProductName.Text + " was updated successfully");
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
