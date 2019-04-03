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
    public partial class frmCustomersAdd : Form
    {
        public frmCustomersAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomersAdd_Load(object sender, EventArgs e)
        {

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            try
            {
                conn.Open();

                // populate category's combo box with existing categories
                string selectQuery = "SELECT * FROM Categories";
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cbCategory.Items.Add(rdr["Category"].ToString());
                    lbCategoryID.Items.Add(int.Parse(rdr["CategoryID"].ToString()));
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

            if (GlobalVariables.selectedCustomerID == 0)
            {
                btnAdd.Text = "&Add";
            }
            else
            {
                txtCustomerID.Text = GlobalVariables.selectedCustomerID.ToString();
                btnAdd.Text = "&Update";

                try
                {
                    conn.Open();

                    // populate input fields with selected customer details
                    string selectQuery = "SELECT * FROM Customers WHERE CustomerID = " + txtCustomerID.Text;
                    SqlCommand cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();

                    txtFirstName.Text = (rdr["FirstName"].ToString());
                    txtLastName.Text = (rdr["LastName"].ToString());
                    rbMale.Checked = true;

                    if (rdr["Gender"].ToString() == "F")
                    {
                        rbFemale.Checked = true;
                    }

                    int datetime = rdr.GetOrdinal("BirthDate");
                    dtpDob.Value = rdr.GetDateTime(datetime);
                    lbCategoryID.SelectedIndex = int.Parse(rdr["CategoryID"].ToString()) - 1;
                    cbCategory.SelectedIndex = lbCategoryID.SelectedIndex;
                    txtAddress.Text = rdr["Address"].ToString();
                    txtSuburb.Text = rdr["Suburb"].ToString();
                    cbState.Text = rdr["State"].ToString();
                    txtPostcode.Text = rdr["Postcode"].ToString();

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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            // check for invalid input fields
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please enter a first name");
                return;
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please enter a last name");
                return;
            }

            string gender = "M";
            if (rbFemale.Checked)
            {
                gender = "F";
            }

            if (string.IsNullOrEmpty(cbCategory.Text))
            {
                MessageBox.Show("Please enter a Category name");
                return;
            }

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please enter a Category name");
                return;
            }

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please enter an address");
                return;
            }

            if (string.IsNullOrEmpty(txtSuburb.Text))
            {
                MessageBox.Show("Please enter a suburb");
                return;
            }

            if (string.IsNullOrEmpty(cbState.Text))
            {
                MessageBox.Show("Please enter a state");
                return;
            }

            int output;
            if (!int.TryParse(txtPostcode.Text, out output))
            {
                MessageBox.Show("Please enter a postcode");
                return;
            }

            SqlConnection conn = ConnectionManager.DatabaseConnection();

            try
            {
                conn.Open();
                SqlCommand cmd = null;

                // check if customer exists with stored procedure
                if (GlobalVariables.selectedCustomerID == 0)
                {
                    string existsQuery = "DECLARE @RecordCount int EXEC dbo.sp_Customers_ExistsCustomer " +
                        txtFirstName.Text + ", " + txtLastName.Text + ", " + txtAddress.Text + ", " +
                        txtSuburb.Text + ", " + cbState.Text + ", " + txtPostcode.Text +
                        ", @RecordCount output SELECT @RecordCount AS RC";

                    SqlDataReader rdr = null;
                    cmd = new SqlCommand(existsQuery, conn);
                    rdr = cmd.ExecuteReader();
                    rdr.Read();

                    if (int.Parse(rdr["RC"].ToString()) > 0)
                    {
                        MessageBox.Show("Customer already exists");
                    }

                    else
                    {
                        rdr.Close();

                        // creates customer with stored procedure
                        string selectQuery = "DECLARE @NewCustomerID int EXEC dbo.sp_Customers_CreateCustomer " +
                           (cbCategory.SelectedIndex + 1) +", " + txtFirstName.Text + ", " + txtLastName.Text + ", " +
                        txtAddress.Text + ", " + txtSuburb.Text + ", " + cbState.Text + ", " + txtPostcode.Text +
                        ", " + gender + ", '" + dtpDob.Value.Date + "', @NewCustomerID output";

                        cmd.CommandText = selectQuery;
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        MessageBox.Show("Customer " + txtFirstName.Text + " " + txtLastName.Text + " was created");
                        this.Close();
                    }

                    if (rdr != null)
                    {
                        rdr.Close();
                    }
                }

                else
                {
                    // updates customer with stored procedure
                    string selectQuery = "dbo.sp_Customers_UpdateCustomer ";

                    cmd = new SqlCommand(selectQuery, conn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
                    cmd.Parameters.AddWithValue("@CategoryID", lbCategoryID.Items[cbCategory.SelectedIndex]);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Suburb", txtSuburb.Text);
                    cmd.Parameters.AddWithValue("@State", cbState.Text);
                    cmd.Parameters.AddWithValue("@Postcode", txtPostcode.Text);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@BirthDate", dtpDob.Value.Date);
                    cmd.Transaction = conn.BeginTransaction();
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();

                    MessageBox.Show("Customer " + txtFirstName.Text + " " + txtLastName.Text + " was updated successfully");
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
