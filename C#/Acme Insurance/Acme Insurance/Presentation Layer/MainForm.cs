using Acme_Insurance.Business_Logic_Layer;
using Acme_Insurance.Data_Access_Layer;
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
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        // populates list view with all products including a total dollar figure of sales
        private void DisplayProducts()
        {
            string selectQuery;

            selectQuery = "select Products.ProductName, ProductTypes.ProductType, SUM(Sales.SaleID) AS Purch " +
                "from Products join ProductTypes ON Products.ProductTypeID = ProductTypes.ProductTypeID " +
                "JOIN Sales ON Products.ProductID = Sales.ProductID group by ProductName, ProductTypes.ProductType " +
                "order by ProductName";

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ListViewItem lvi = new ListViewItem(rdr["ProductName"].ToString());
                    lvi.SubItems.Add(rdr["ProductType"].ToString());
                    lvi.SubItems.Add(rdr["Purch"].ToString());
                    lvProductsDisplay.Items.Add(lvi);
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

        // closes the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // loads customer view form
        private void btnCustomersView_Click(object sender, EventArgs e)
        {
            frmCustomersView editForm = new frmCustomersView();
            editForm.Show();
        }

        // loads sales view form
        private void btnSalesView_Click(object sender, EventArgs e)
        {
            frmSalesView editForm = new frmSalesView();
            editForm.Show();
        }

        // loads categories view form
        private void btnCategoriesView_Click(object sender, EventArgs e)
        {
            frmCategoriesView viewForm = new frmCategoriesView();
            viewForm.Show();
        }

        // loads products view form
        private void btnProductView_Click(object sender, EventArgs e)
        {
            frmProductsView viewForm = new frmProductsView();
            viewForm.Show();
        }

        // loads product types view form
        private void btnProductTypeView_Click(object sender, EventArgs e)
        {
            frmProductTypesView viewForm = new frmProductTypesView();
            viewForm.Show();
        }

        // loads tutorial form
        private void btnTutorial_Click(object sender, EventArgs e)
        {
            frmTutorial tutForm = new frmTutorial();
            tutForm.ShowDialog();
        }

        // loads about form
        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout aboutForm = new frmAbout();
            aboutForm.ShowDialog();
        }
    }
}
