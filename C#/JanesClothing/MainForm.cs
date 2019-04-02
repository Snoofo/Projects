using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanesClothing
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmCustomersAdd addForm = new frmCustomersAdd();
            addForm.Show();
            this.Hide();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            frmCustomersEdit editForm = new frmCustomersEdit();
            editForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmProductsAdd addForm = new frmProductsAdd();
            addForm.Show();
            this.Hide();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            frmProductsEdit editForm = new frmProductsEdit();
            editForm.Show();
            this.Hide();
        }
    }
}
