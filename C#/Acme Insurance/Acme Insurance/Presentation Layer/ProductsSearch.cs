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
    public partial class frmProductsSearch : Form
    {
        public frmProductsSearch()
        {
            InitializeComponent();
        }

        private void frmProductsSearch_Load(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            try
            {
                conn.Open();

                // populates product type combo box with existing product types
                string selectQuery = "SELECT DISTINCT ProductName, Products.ProductTypeID " +
                    "FROM Products JOIN ProductTypes ON Products.ProductTypeID = ProductTypes.ProductTypeID";
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cbProductType.Items.Add(rdr["ProductName"].ToString());
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // enables corresponding input fields to selected search criteria
        private void All_CheckedChanged(object sender, EventArgs e)
        {
            txtProductID.Enabled = false;
            cbProductType.Enabled = false;
        }

        private void rbProductID_CheckedChanged(object sender, EventArgs e)
        {
            txtProductID.Enabled = true;
            cbProductType.Enabled = false;
        }

        private void rbProductType_CheckedChanged(object sender, EventArgs e)
        {
            txtProductID.Enabled = false;
            cbProductType.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlCommand cmd = null;
            SqlDataReader rdr = null;

            try
            {
                conn.Open();

                // search for and display all products
                if (rbAll.Checked)
                {
                    string selectQuery = "SELECT * FROM Products";

                    cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();

                    lvSearchResult.Items.Clear();

                    // populate list view with returned product details
                    while (rdr.Read())
                    {
                        Product product = new Product(int.Parse(rdr["ProductID"].ToString()),
                            int.Parse(rdr["ProductTypeID"].ToString()), rdr["ProductName"].ToString(),
                            double.Parse(rdr["YearlyPremium"].ToString()));
                        ListViewItem lvi = new ListViewItem(product.ProductID.ToString());
                        lvi.SubItems.Add(product.ProductTypeID.ToString());
                        lvi.SubItems.Add(product.ProductName.ToString());
                        lvi.SubItems.Add(product.YearlyPremium.ToString());
                        lvSearchResult.Items.Add(lvi);
                    }
                }

                // search for and display all products with selected product type
                else if (rbProductType.Checked)
                {
                    if (string.IsNullOrEmpty(cbProductType.Text))
                    {
                        MessageBox.Show("Please enter a product type");
                        return;
                    }

                    string selectQuery = "SELECT DISTINCT ProductName, Products.ProductTypeID, ProductID, " +
                        "YearlyPremium FROM Products JOIN ProductTypes ON Products.ProductTypeID = " +
                        "ProductTypes.ProductTypeID WHERE Products.ProductTypeID = " +
                        lbProductTypeID.Items[cbProductType.SelectedIndex];

                    cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();

                    lvSearchResult.Items.Clear();

                    // populate list view with returned product details
                    while (rdr.Read())
                    {
                        Product product = new Product(int.Parse(rdr["ProductID"].ToString()),
                            int.Parse(rdr["ProductTypeID"].ToString()), rdr["ProductName"].ToString(),
                            double.Parse(rdr["YearlyPremium"].ToString()));
                        ListViewItem lvi = new ListViewItem(product.ProductID.ToString());
                        lvi.SubItems.Add(product.ProductTypeID.ToString());
                        lvi.SubItems.Add(product.ProductName.ToString());
                        lvi.SubItems.Add(product.YearlyPremium.ToString());
                        lvSearchResult.Items.Add(lvi);
                    }

                    if (lvSearchResult.Items.Count == 0)
                    {
                        MessageBox.Show("Nothing found matching " + cbProductType.Text);
                    }
                }

                // search for and display all products with matching product ID
                else if (rbProductID.Checked)
                {
                    int output;
                    if (!int.TryParse(txtProductID.Text, out output))
                    {
                        MessageBox.Show("Product ID must be an integer");
                        return;
                    }

                    string selectQuery = "SELECT * FROM Products WHERE ProductID = "
                        + txtProductID.Text;

                    cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();

                    lvSearchResult.Items.Clear();

                    // populate list view with returned product details
                    while (rdr.Read())
                    {
                        Product product = new Product(int.Parse(rdr["ProductID"].ToString()),
                            int.Parse(rdr["ProductTypeID"].ToString()), rdr["ProductName"].ToString(),
                            double.Parse(rdr["YearlyPremium"].ToString()));
                        ListViewItem lvi = new ListViewItem(product.ProductID.ToString());
                        lvi.SubItems.Add(product.ProductTypeID.ToString());
                        lvi.SubItems.Add(product.ProductName.ToString());
                        lvi.SubItems.Add(product.YearlyPremium.ToString());
                        lvSearchResult.Items.Add(lvi);
                    }

                    if (lvSearchResult.Items.Count == 0)
                    {
                        MessageBox.Show("Nothing found matching " + txtProductID.Text);
                    }
                }

                if (rdr != null)
                {
                    rdr.Close();
                }

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to database: \n\n" + ex.ToString());
            }
        }
    }
}
