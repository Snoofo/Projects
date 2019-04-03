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
    public partial class frmSalesAdd : Form
    {
        public frmSalesAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSalesAdd_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.selectedSaleID == 0)
            {
                btnAdd.Text = "&Add";
            }

            else
            {
                // disable unchangable input fields if updating sale
                txtCustomerID.Enabled = false;
                txtProductID.Enabled = false;
                txtSaleID.Text = GlobalVariables.selectedSaleID.ToString();
                btnAdd.Text = "&Update";

                SqlConnection conn = ConnectionManager.DatabaseConnection();
                SqlDataReader rdr = null;

                try
                {
                    conn.Open();

                    // populate input fields with selected sale details
                    string selectQuery = "SELECT * FROM Sales WHERE SaleID = " +
                        txtSaleID.Text;
                    SqlCommand cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();

                    rdr.Read();
                    txtCustomerID.Text = rdr["CustomerID"].ToString();
                    txtProductID.Text = rdr["ProductID"].ToString();
                    switch (rdr["Payable"].ToString())
                    {
                        case "F":
                            {
                                rbFortnightly.Checked = true;
                                break;
                            }
                        case "M":
                            {
                                rbMonthly.Checked = true;
                                break;
                            }
                        case "Y":
                            {
                                rbYearly.Checked = true;
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                    dtpStartDate.Value = DateTime.Parse(rdr["StartDate"].ToString());

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // check all input fields are valid
            string payable = "";
            int output;
            if (!int.TryParse(txtCustomerID.Text, out output))
            {
                MessageBox.Show("Customer ID must be an integer");
                return;
            }

            if (!int.TryParse(txtProductID.Text, out output))
            {
                MessageBox.Show("Product ID must be an integer");
                return;
            }

            if (rbFortnightly.Checked)
            {
                payable = "F";
            }

            else if (rbMonthly.Checked)
            {
                payable = "M";
            }

            else if (rbYearly.Checked)
            {
                payable = "Y";
            }

            SqlConnection conn = ConnectionManager.DatabaseConnection();

            try
            {
                conn.Open();
                SqlCommand cmd = null;
                SqlDataReader rdr = null;

                string customerID = txtCustomerID.Text;
                string productID = txtProductID.Text;

                // check if customer ID exists
                string existsQuery = "";

                existsQuery = "SELECT count(*) AS Count FROM Customers WHERE CustomerID = " + txtCustomerID.Text;

                cmd = new SqlCommand(existsQuery, conn);
                rdr = cmd.ExecuteReader();
                rdr.Read();

                if (int.Parse(rdr["Count"].ToString()) == 0)
                {
                    MessageBox.Show("Cannot add sale:\nCustomer ID does not exist");
                    return;
                }

                rdr.Close();

                // check if product ID exists
                existsQuery = "SELECT count(*) AS Count FROM Products WHERE ProductID = " + txtProductID.Text;

                cmd.CommandText = existsQuery;
                rdr = cmd.ExecuteReader();
                rdr.Read();

                if (int.Parse(rdr["Count"].ToString()) == 0)
                {
                    MessageBox.Show("Cannot add sale:\nProuduct ID does not exist");
                    return;
                }

                rdr.Close();

                if (GlobalVariables.selectedSaleID == 0)
                {
                    // check if sale exists with stored procedure
                    existsQuery = "DECLARE @RecordCount int EXEC dbo.sp_Sales_ExistsSale " + txtCustomerID.Text +
                        ", " + txtProductID.Text + ", @RecordCount output SELECT @RecordCount AS RC";
                    
                    cmd = new SqlCommand(existsQuery, conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();

                    if (int.Parse(rdr["RC"].ToString()) > 0)
                    {
                        MessageBox.Show("Sale already exists");
                    }

                    else
                    {
                        rdr.Close();

                        // create sale with stored procedure
                        string selectQuery = "DECLARE @NewSaleID int EXEC dbo.sp_Sales_CreateSale " +
                            txtCustomerID.Text + ", " + txtProductID.Text + ", " + payable + ", '" +
                            dtpStartDate.Value.Date + "', @NewSaleID output SELECT @NewSaleID AS SaleID";

                        cmd.CommandText = selectQuery;
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        MessageBox.Show("Sale was created");
                        this.Close();
                    }

                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                }

                else
                {
                    // update sale with stored procedure
                    string selectQuery = "dbo.sp_Sales_UpdateSale ";

                    cmd = new SqlCommand(selectQuery, conn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SaleID", txtSaleID.Text);
                    cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
                    cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text);
                    cmd.Parameters.AddWithValue("@Payable", payable);
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date);
                    cmd.Transaction = conn.BeginTransaction();
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();

                    MessageBox.Show("Sale ID " + txtSaleID.Text + " was updated successfully");
                        this.Close();

                    if (rdr != null)
                    {
                        rdr.Close();
                    }
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
