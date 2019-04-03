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
    public partial class frmProductTypesSearch : Form
    {
        public frmProductTypesSearch()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // enables corresponding input fields to selected search criteria
        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            txtProductTypeID.Enabled = false;
        }

        private void rbProductTypeID_CheckedChanged(object sender, EventArgs e)
        {
            txtProductTypeID.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlCommand cmd = null;
            SqlDataReader rdr = null;

            try
            {
                conn.Open();

                // search for and displays all product types
                if (rbAll.Checked)
                {
                    string selectQuery = "SELECT * FROM ProductTypes";

                    cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();

                    lvSearchResult.Items.Clear();

                    // populate list view with returned product type details
                    while (rdr.Read())
                    {
                        ProductType productType = new ProductType(int.Parse(rdr["ProductTypeID"].ToString()),
                            rdr["ProductType"].ToString());
                        ListViewItem lvi = new ListViewItem(productType.ProductTypeID.ToString());
                        lvi.SubItems.Add(productType.ProductTypeName.ToString());
                        lvSearchResult.Items.Add(lvi);
                    }
                }

                // search for and displays all product types matching product type ID
                else if (rbProductTypeID.Checked)
                {
                    int output;
                    if (!int.TryParse(txtProductTypeID.Text, out output))
                    {
                        MessageBox.Show("Please enter a product type ID");
                        return;
                    }

                    string selectQuery = "SELECT * FROM ProductTypes WHERE ProductTypeID = " + txtProductTypeID.Text;

                    cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();

                    lvSearchResult.Items.Clear();

                    // populate list view with returned product type details
                    while (rdr.Read())
                    {
                        ProductType productType = new ProductType(int.Parse(rdr["ProductTypeID"].ToString()),
                            rdr["ProductType"].ToString());
                        ListViewItem lvi = new ListViewItem(productType.ProductTypeID.ToString());
                        lvi.SubItems.Add(productType.ProductTypeName.ToString());
                        lvSearchResult.Items.Add(lvi);
                    }

                    if (lvSearchResult.Items.Count == 0)
                    {
                        MessageBox.Show("Nothing found matching " + txtProductTypeID.Text);
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
