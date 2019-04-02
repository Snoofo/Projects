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
    public partial class frmCustomersAdd : Form
    {
        public frmCustomersAdd()
        {
            InitializeComponent();
        }

        private void frmCustomersAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainForm mainForm = new frmMainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            cbCategoryID.SelectedIndex = -1;
            txtAddress.Clear();
            txtSuburb.Clear();
            cbState.SelectedIndex = -1;
            txtPostcode.Clear();
            txtCustomerID.Clear();
            chkYes.Checked = false;
            chkNo.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
