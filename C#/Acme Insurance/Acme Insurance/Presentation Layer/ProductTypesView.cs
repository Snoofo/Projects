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
    public partial class frmProductTypesView : Form
    {
        public frmProductTypesView()
        {
            InitializeComponent();
        }

        private void frmProductTypesView_Load(object sender, EventArgs e)
        {
            DisplayProductTypes();
        }

        // displays all product type details
        private void DisplayProductTypes()
        {
            string selectQuery = "SELECT * FROM ProductTypes";

            SqlConnection conn = ConnectionManager.DatabaseConnection();
            SqlDataReader rdr = null;

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(selectQuery, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ProductType productType = new ProductType(int.Parse(rdr["ProductTypeID"].ToString()), rdr["ProductType"].ToString());
                    ListViewItem lvi = new ListViewItem(productType.ProductTypeID.ToString());
                    lvi.SubItems.Add(productType.ProductTypeName.ToString());
                    lvProductTypes.Items.Add(lvi);
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
            GlobalVariables.selectedProductType = 0;
            frmProductTypesAdd editForm = new frmProductTypesAdd();
            editForm.ShowDialog();
            // repopulate list view with updated product types details
            lvProductTypes.Items.Clear();
            DisplayProductTypes();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvProductTypes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Product Type to update");
                return;
            }
            GlobalVariables.selectedProductType = int.Parse(lvProductTypes.SelectedItems[0].Text);
            frmProductTypesAdd editForm = new frmProductTypesAdd();
            editForm.ShowDialog();
            // repopulate list view with updated product types details
            lvProductTypes.Items.Clear();
            DisplayProductTypes();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmProductTypesSearch searchForm = new frmProductTypesSearch();
            searchForm.ShowDialog();
        }

        // deletes selected product type
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // ensure an item is selected
            if (lvProductTypes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a product type to delete");
                return;
            }

            string productTypeID = lvProductTypes.SelectedItems[0].Text;

            // display delete confirmation box
            DialogResult result = MessageBox.Show("Are you sure you want to delete product type " +
                productTypeID, "Delete Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // check is product type can be deleted with stored procedure
                string allowDelete = "DECLARE @RecordCount int EXEC dbo.sp_ProductTypes_AllowDeleteProductType "
                    + productTypeID + ", @RecordCount output SELECT @RecordCount AS RC";
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

                        // deletes product type with stored procedure
                        cmd.CommandText = "EXEC dbo.sp_ProductTypes_DeleteProductType " + productTypeID;
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        MessageBox.Show("Sucessfully deleted product " + productTypeID);
                    }

                    else
                    {
                        MessageBox.Show("Product is in use by a Sale it cannot be deleted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not delete product " + productTypeID + "\n" + ex.ToString());
                }
                // repopulate list view with updated product types details
                lvProductTypes.Items.Clear();
                DisplayProductTypes();
            }
        }
    }
}
