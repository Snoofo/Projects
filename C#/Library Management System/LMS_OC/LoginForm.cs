using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LMS_OC
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInput() == false) return;
            DataTable dt = ConnectionManager.GetTable("select * from Librarian where userName='" + txtUserName.Text + "' and password='" + txtPassword.Text + "' ");
            if (dt.Rows.Count != 0)
            {
                System.Environment.SetEnvironmentVariable("librarianID", dt.Rows[0]["librarianID"].ToString());
                System.Environment.SetEnvironmentVariable("librarianName", dt.Rows[0]["firstName"].ToString());
                new MainForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid user name or password, try again.");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
                
        }
        private bool ValidateInput()
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("User name can not be null.");
                txtUserName.Focus();
                return false ;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password can not be null.");
                txtPassword.Focus();
                return false ;
            }
            return true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.Text = "jessica";
            txtUserName.Text = "jessica";
        }
    }
}
