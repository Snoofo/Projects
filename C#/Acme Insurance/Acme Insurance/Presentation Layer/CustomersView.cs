using Acme_Insurance.Data_Access_Layer;
using Acme_Insurance.Presentation_Layer;
using Acme_Insurance.Business_Logic_Layer;
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
    public partial class frmCustomersView : Form
    {
        public frmCustomersView()
        {
            InitializeComponent();
        }

        // populates list view to display all customers details
        private void DisplayCustomers()
        {
            string selectQuery = "SELECT * FROM Customers";

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    Customer customer = new Customer(int.Parse(rdr["CustomerID"].ToString()), int.Parse(rdr["CategoryID"].ToString()),
                        rdr["FirstName"].ToString(), rdr["LastName"].ToString(), rdr["Address"].ToString(), rdr["Suburb"].ToString(),
                        rdr["State"].ToString(), int.Parse(rdr["Postcode"].ToString()), rdr["Gender"].ToString(), DateTime.Parse(rdr["BirthDate"].ToString()));
                    ListViewItem lvi = new ListViewItem(customer.CustomerID.ToString());
                    lvi.SubItems.Add(customer.CategoryID.ToString());
                    lvi.SubItems.Add(customer.FirstName.ToString());
                    lvi.SubItems.Add(customer.LastName.ToString());
                    lvi.SubItems.Add(customer.Address.ToString());
                    lvi.SubItems.Add(customer.Suburb.ToString());
                    lvi.SubItems.Add(customer.State.ToString());
                    lvi.SubItems.Add(customer.Postcode.ToString());
                    lvi.SubItems.Add(customer.Gender.ToString());
                    lvi.SubItems.Add(customer.BirthDate.ToShortDateString());
                    lvCustomers.Items.Add(lvi);
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

        private void frmCustomersView_Load(object sender, EventArgs e)
        {
            DisplayCustomers();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GlobalVariables.selectedCustomerID = 0;
            frmCustomersAdd editForm = new frmCustomersAdd();
            editForm.ShowDialog();
            // repopulate list view with updated customer details
            lvCustomers.Items.Clear();
            DisplayCustomers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvCustomers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Customer to update");
                return;
            }
            GlobalVariables.selectedCustomerID = int.Parse(lvCustomers.SelectedItems[0].Text);
            frmCustomersAdd editForm = new frmCustomersAdd();
            editForm.ShowDialog();
            // repopulate list view with updated customer details
            lvCustomers.Items.Clear();
            DisplayCustomers();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmCustomersSearch searchForm = new frmCustomersSearch();
            searchForm.ShowDialog();
        }

        // deletes a customer
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // check for selected index
            if (lvCustomers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Customer to delete");
                return;
            }

            string customerID = lvCustomers.SelectedItems[0].Text;

            // display confirmation to delete
            DialogResult result = MessageBox.Show("Are you sure you want to delete customer " + customerID, "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // check customer can be deleted with stored procedure
                string allowDelete = "DECLARE @RecordCount int EXEC dbo.sp_Customers_AllowDeleteCustomer "
                    + customerID + ", @RecordCount output SELECT @RecordCount AS RC";
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
                        // delete customer with stored procedure
                        rdr.Close();
                        cmd.CommandText = "EXEC dbo.sp_Customers_DeleteCustomer " + customerID;
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        MessageBox.Show("Sucessfully deleted customer " + customerID);
                    }

                    else
                    {
                        MessageBox.Show("Customer is in use by a Sale it cannot be deleted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not delete customer " + customerID + "\n" + ex.ToString());
                }
                // repopulate list view with updated customer details
                lvCustomers.Items.Clear();
                DisplayCustomers();
            }
        }
    }
}
