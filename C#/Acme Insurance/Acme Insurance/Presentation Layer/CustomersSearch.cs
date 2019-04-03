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
    public partial class frmCustomersSearch : Form
    {
        public frmCustomersSearch()
        {
            InitializeComponent();
        }

        private void frmCustomersSearch_Load(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            try
            {
                conn.Open();

                // populates category's combo box with existing categories
                string selectQuery = "SELECT DISTINCT Category, Customers.CategoryID " +
                    "FROM Customers JOIN Categories ON Customers.CategoryID = Categories.CategoryID";
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // enables corresponding input fields to selected search criteria
        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = false;
            cbCategory.Enabled = false;
            rbMale.Enabled = false;
            rbFemale.Enabled = false;
        }

        private void rbCustomerID_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = true;
            cbCategory.Enabled = false;
            rbMale.Enabled = false;
            rbFemale.Enabled = false;
        }

        private void rbCategory_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = false;
            cbCategory.Enabled = true;
            rbMale.Enabled = false;
            rbFemale.Enabled = false;
        }

        private void rbGender_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomerID.Enabled = false;
            cbCategory.Enabled = false;
            rbMale.Enabled = true;
            rbFemale.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlCommand cmd = null;
            SqlDataReader rdr = null;

            try
            {
                conn.Open();

                // search for and display all Customers
                if (rbAll.Checked)
                {
                    string selectQuery = "SELECT * FROM Customers";

                    cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();

                    lvSearchResult.Items.Clear();

                    // populate list view with returned customer details
                    while (rdr.Read())
                    {
                        Customer customer = new Customer(int.Parse(rdr["CustomerID"].ToString()),
                            int.Parse(rdr["CategoryID"].ToString()), rdr["FirstName"].ToString(),
                            rdr["LastName"].ToString(), rdr["Address"].ToString(), rdr["Suburb"].ToString(),
                            rdr["State"].ToString(), int.Parse(rdr["Postcode"].ToString()),
                            rdr["Gender"].ToString(), DateTime.Parse(rdr["BirthDate"].ToString()));
                        ListViewItem lvi = new ListViewItem(customer.CustomerID.ToString());
                        lvi.SubItems.Add(customer.CategoryID.ToString());
                        lvi.SubItems.Add(customer.FirstName.ToString());
                        lvi.SubItems.Add(customer.LastName.ToString());
                        lvi.SubItems.Add(customer.Gender.ToString());
                        lvSearchResult.Items.Add(lvi);
                    }
                }

                // search for and display customer with customer ID
                else if (rbCustomerID.Checked)
                {
                    if (string.IsNullOrEmpty(txtCustomerID.Text))
                    {
                        MessageBox.Show("Please enter a customer ID");
                        return;
                    }

                    string selectQuery = "SELECT * FROM Customers WHERE CustomerID = "
                        + txtCustomerID.Text;

                    cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();

                    lvSearchResult.Items.Clear();

                    // populate list view with returned customer details
                    while (rdr.Read())
                    {
                        Customer customer = new Customer(int.Parse(rdr["CustomerID"].ToString()),
                            int.Parse(rdr["CategoryID"].ToString()), rdr["FirstName"].ToString(),
                            rdr["LastName"].ToString(), rdr["Address"].ToString(), rdr["Suburb"].ToString(),
                            rdr["State"].ToString(), int.Parse(rdr["Postcode"].ToString()),
                            rdr["Gender"].ToString(), DateTime.Parse(rdr["BirthDate"].ToString()));
                        ListViewItem lvi = new ListViewItem(customer.CustomerID.ToString());
                        lvi.SubItems.Add(customer.CategoryID.ToString());
                        lvi.SubItems.Add(customer.FirstName.ToString());
                        lvi.SubItems.Add(customer.LastName.ToString());
                        lvi.SubItems.Add(customer.Gender.ToString());
                        lvSearchResult.Items.Add(lvi);
                    }

                    if (lvSearchResult.Items.Count == 0)
                    {
                        MessageBox.Show("Nothing found matching " + txtCustomerID.Text);
                    }
                }

                // search for and display all customers with selected category ID
                else if (rbCategory.Checked)
                {
                    if (string.IsNullOrEmpty(cbCategory.Text))
                    {
                        MessageBox.Show("Please select a category");
                        return;
                    }

                    string selectQuery = "SELECT * FROM Customers WHERE CategoryID = "
                        + (cbCategory.SelectedIndex + 1);

                    cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();

                    lvSearchResult.Items.Clear();

                    // populate list view with returned customer details
                    while (rdr.Read())
                    {
                        Customer customer = new Customer(int.Parse(rdr["CustomerID"].ToString()),
                            int.Parse(rdr["CategoryID"].ToString()), rdr["FirstName"].ToString(),
                            rdr["LastName"].ToString(), rdr["Address"].ToString(), rdr["Suburb"].ToString(),
                            rdr["State"].ToString(), int.Parse(rdr["Postcode"].ToString()),
                            rdr["Gender"].ToString(), DateTime.Parse(rdr["BirthDate"].ToString()));
                        ListViewItem lvi = new ListViewItem(customer.CustomerID.ToString());
                        lvi.SubItems.Add(customer.CategoryID.ToString());
                        lvi.SubItems.Add(customer.FirstName.ToString());
                        lvi.SubItems.Add(customer.LastName.ToString());
                        lvi.SubItems.Add(customer.Gender.ToString());
                        lvSearchResult.Items.Add(lvi);
                    }

                    if (lvSearchResult.Items.Count == 0)
                    {
                        MessageBox.Show("Nothing found matching " + cbCategory.Text);
                    }
                }

                // search for and display all Customers with selected gender
                else if (rbGender.Checked)
                {
                    string selectQuery = "";

                    if (rbMale.Checked)
                    {
                        selectQuery = "SELECT * FROM Customers WHERE Gender = 'M'";
                    }

                    else if (rbFemale.Checked)
                    {
                        selectQuery = "SELECT * FROM Customers WHERE Gender = 'F'";
                    }

                    cmd = new SqlCommand(selectQuery, conn);
                    rdr = cmd.ExecuteReader();

                    lvSearchResult.Items.Clear();

                    // populate list view with returned customer details
                    while (rdr.Read())
                    {
                        Customer customer = new Customer(int.Parse(rdr["CustomerID"].ToString()),
                            int.Parse(rdr["CategoryID"].ToString()), rdr["FirstName"].ToString(),
                            rdr["LastName"].ToString(), rdr["Address"].ToString(), rdr["Suburb"].ToString(),
                            rdr["State"].ToString(), int.Parse(rdr["Postcode"].ToString()),
                            rdr["Gender"].ToString(), DateTime.Parse(rdr["BirthDate"].ToString()));
                        ListViewItem lvi = new ListViewItem(customer.CustomerID.ToString());
                        lvi.SubItems.Add(customer.CategoryID.ToString());
                        lvi.SubItems.Add(customer.FirstName.ToString());
                        lvi.SubItems.Add(customer.LastName.ToString());
                        lvi.SubItems.Add(customer.Gender.ToString());
                        lvSearchResult.Items.Add(lvi);
                    }

                    if (lvSearchResult.Items.Count == 0)
                    {
                        MessageBox.Show("Nothing found matching " + cbCategory.Text);
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
