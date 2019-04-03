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

namespace Acme_Insurance
{
    public partial class frmSalesView : Form
    {
        public frmSalesView()
        {
            InitializeComponent();
        }

        private void frmSalesView_Load(object sender, EventArgs e)
        {
            DisplaySales();
        }

        // populates list view with all sales details
        private void DisplaySales()
        {
            string selectQuery = "SELECT * FROM Sales JOIN Products ON Sales.ProductID = Products.ProductID";
            double premium = 0;
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    switch (rdr["Payable"].ToString())
                    {
                        case "Y":
                            {
                                premium = double.Parse(rdr["YearlyPremium"].ToString());
                                break;
                            }
                        case "M":
                            {
                                premium = double.Parse(rdr["YearlyPremium"].ToString()) / 12;
                                break;
                            }
                        case "F":
                            {
                                premium = double.Parse(rdr["YearlyPremium"].ToString()) / 26;
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                    Sale sale = new Sale(int.Parse(rdr["SaleID"].ToString()), int.Parse(rdr["CustomerID"].ToString()),
                        int.Parse(rdr["ProductID"].ToString()), rdr["Payable"].ToString(), DateTime.Parse(rdr["StartDate"].ToString()));
                    ListViewItem lvi = new ListViewItem(sale.SaleID.ToString());
                    lvi.SubItems.Add(sale.CustomerID.ToString());
                    lvi.SubItems.Add(sale.ProductID.ToString());
                    lvi.SubItems.Add(sale.Payable.ToString());
                    lvi.SubItems.Add(premium.ToString("N2"));
                    lvi.SubItems.Add(sale.StartDate.ToShortDateString());
                    lvSales.Items.Add(lvi);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalVariables.selectedSaleID = 0;
            frmSalesAdd editForm = new frmSalesAdd();
            editForm.ShowDialog();
            // repopulate list view with updated sales details
            lvSales.Items.Clear();
            DisplaySales();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvSales.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Sale to update");
                return;
            }
            GlobalVariables.selectedSaleID = int.Parse(lvSales.SelectedItems[0].Text);
            frmSalesAdd editForm = new frmSalesAdd();
            editForm.ShowDialog();
            // repopulate list view with updated sales details
            lvSales.Items.Clear();
            DisplaySales();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSalesSearch searchForm = new frmSalesSearch();
            searchForm.ShowDialog();
        }

        // deletes selected sale
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // check for selected index
            if (lvSales.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a sale to delete");
                return;
            }

            string saleID = lvSales.SelectedItems[0].Text;

            // display delete confirmation box
            DialogResult result = MessageBox.Show("Are you sure you want to delete sale ID " +
                saleID, "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // deletes sale with stored procedure
                string deleteQuery = "EXEC dbo.sp_Sales_DeleteSale " + saleID;
                SqlConnection conn = ConnectionManager.DatabaseConnection();

                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                    cmd.Transaction = conn.BeginTransaction();
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();

                    MessageBox.Show("Sucessfully deleted sale " + saleID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not delete product " + saleID + "\n" + ex.ToString());
                }
                // repopulate list view with updated sales details
                lvSales.Items.Clear();
                DisplaySales();
            }
        }
    }
}
