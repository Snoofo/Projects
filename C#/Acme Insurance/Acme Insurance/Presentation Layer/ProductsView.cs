using Acme_Insurance.Data_Access_Layer;
using Acme_Insurance.Business_Logic_Layer;
using Acme_Insurance.Presentation_Layer;
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
    public partial class frmProductsView : Form
    {
        public frmProductsView()
        {
            InitializeComponent();
        }

        private void frmProductsView_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        // populates list view with all product details
        private void DisplayProducts()
        {
            string selectQuery = "SELECT * FROM Products";

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Product product = new Product(int.Parse(rdr["ProductID"].ToString()), int.Parse(rdr["ProductTypeID"].ToString()),
                        rdr["ProductName"].ToString(), float.Parse(rdr["YearlyPremium"].ToString()));
                    ListViewItem lvi = new ListViewItem(product.ProductID.ToString());
                    lvi.SubItems.Add(product.ProductTypeID.ToString());
                    lvi.SubItems.Add(product.ProductName.ToString());
                    lvi.SubItems.Add(product.YearlyPremium.ToString());
                    lvProducts.Items.Add(lvi);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalVariables.selectedProductID = 0;
            frmProductsAdd editForm = new frmProductsAdd();
            editForm.ShowDialog();
            // repopulates list view with updated product details
            lvProducts.Items.Clear();
            DisplayProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Product to update");
                return;
            }
            GlobalVariables.selectedProductID = int.Parse(lvProducts.SelectedItems[0].Text);
            frmProductsAdd editForm = new frmProductsAdd();
            editForm.ShowDialog();
            // repopulates list view with updated product details
            lvProducts.Items.Clear();
            DisplayProducts();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmProductsSearch searchForm = new frmProductsSearch();
            searchForm.ShowDialog();
        }

        // deletes selected product
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // ensure a product is selected
            if (lvProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a product to delete");
                return;
            }

            string productID = lvProducts.SelectedItems[0].Text;

            // display confirmation box to delete
            DialogResult result = MessageBox.Show("Are you sure you want to delete product " +
                productID, "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // check if product can be deleted with stored procedure
                string allowDelete = "DECLARE @RecordCount int EXEC dbo.sp_Products_AllowDeleteProduct "
                    + productID + ", @RecordCount output SELECT @RecordCount AS RC";
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
                        rdr.Close();

                        // deletes product with stored procedure
                        cmd.CommandText = "EXEC dbo.sp_Products_DeleteProduct " + productID;
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        MessageBox.Show("Sucessfully deleted product " + productID);
                    }

                    else
                    {
                        MessageBox.Show("Product is in use by a Sale it cannot be deleted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not delete product " + productID + "\n" + ex.ToString());
                }
                // repopulates list view with updated product details
                lvProducts.Items.Clear();
                DisplayProducts();
            }
        }
    }
}
