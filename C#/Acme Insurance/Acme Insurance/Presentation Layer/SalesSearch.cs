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
    public partial class frmSalesSearch : Form
    {
        public frmSalesSearch()
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
            txtCustomerID.Enabled = false;
            txtSaleID.Enabled = false;
            rbFortnightly.Enabled = false;
            rbMonthly.Enabled = false;
            rbYearly.Enabled = false;
        }

        private void rbSaleID_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = false;
            txtSaleID.Enabled = true;
            rbFortnightly.Enabled = false;
            rbMonthly.Enabled = false;
            rbYearly.Enabled = false;
        }

        private void rbCustomerID_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = true;
            txtSaleID.Enabled = false;
            rbFortnightly.Enabled = false;
            rbMonthly.Enabled = false;
            rbYearly.Enabled = false;
        }

        private void rbPayable_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = false;
            txtSaleID.Enabled = false;
            rbFortnightly.Enabled = true;
            rbMonthly.Enabled = true;
            rbYearly.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            try
            {
                conn.Open();

                string searchCriteria = "";
                string selectQuery = "";

                // search for and display all sales details
                if (rbAll.Checked)
                {
                    selectQuery = "SELECT * FROM Sales";
                }

                // search for and display all sales details matching sale ID
                else if (rbSaleID.Checked)
                {
                    int output;
                    if (!int.TryParse(txtSaleID.Text, out output))
                    {
                        MessageBox.Show("Please enter a sale ID");
                        return;
                    }
                    searchCriteria = txtSaleID.Text;
                    selectQuery = "SELECT * FROM Sales WHERE SaleID = " + searchCriteria;
                }

                // search for and display all sales details matching customer ID
                else if (rbCustomerID.Checked)
                {
                    int output;
                    if (!int.TryParse(txtCustomerID.Text, out output))
                    {
                        MessageBox.Show("Please enter a customer ID");
                        return;
                    }
                    searchCriteria = txtCustomerID.Text;
                    selectQuery = "SELECT * FROM Sales WHERE CustomerID = " + searchCriteria;
                }

                // search for and display all sales details matching selected payable type
                else if (rbPayable.Checked)
                {

                    if (rbFortnightly.Checked)
                    {
                        selectQuery = "SELECT * FROM Sales WHERE Payable = 'F'";
                        searchCriteria = "Fortnightly";
                    }

                    if (rbMonthly.Checked)
                    {
                        selectQuery = "SELECT * FROM Sales WHERE Payable = 'M'";
                        searchCriteria = "Monthly";
                    }

                    if (rbYearly.Checked)
                    {
                        selectQuery = "SELECT * FROM Sales WHERE Payable = 'Y'";
                        searchCriteria = "Yearly";
                    }
                }

                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();

                lvSearchResult.Items.Clear();

                // populate list view with returned sales details
                while (rdr.Read())
                {
                    Sale sale = new Sale(int.Parse(rdr["SaleID"].ToString()), int.Parse(rdr["CustomerID"].ToString()),
                        int.Parse(rdr["ProductID"].ToString()), rdr["Payable"].ToString(), DateTime.Parse(rdr["StartDate"].ToString()));
                    ListViewItem lvi = new ListViewItem(sale.SaleID.ToString());
                    lvi.SubItems.Add(sale.CustomerID.ToString());
                    lvi.SubItems.Add(sale.ProductID.ToString());
                    string payable;
                    switch (sale.Payable.ToString())
                    {
                        case "Y":
                            {
                                payable = "Yearly";
                                break;
                            }
                        case "M":
                            {
                                payable = "Monthly";
                                break;
                            }
                        case "F":
                            {
                                payable = "Fortnightly";
                                break;
                            }
                        default:
                            {
                                payable = "N/A";
                                break;
                            }
                    }
                    lvi.SubItems.Add(payable);
                    lvi.SubItems.Add(sale.StartDate.ToShortDateString());
                    lvSearchResult.Items.Add(lvi);
                }

                if (lvSearchResult.Items.Count == 0)
                {
                    MessageBox.Show("Nothing found matching " + searchCriteria);
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
