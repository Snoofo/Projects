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
    public partial class EditStudentForm : Form
    {
        public EditStudentForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == "")
            {
                MessageBox.Show("Please provide Student ID to search.");
                txtStudentID.Focus();
                return;
            }
            try
            {
                double.Parse(txtStudentID.Text);
            }
            catch
            {
                MessageBox.Show("Accepts only integer number as Student ID.");
                txtStudentID.Text = "";
                txtStudentID.Focus();
                return;
            }

            DataTable studentDT = ConnectionManager.GetTable("select * from Student where studentID=" + txtStudentID.Text + "");
            if (studentDT.Rows.Count == 0)
            {
                MessageBox.Show("Student with student ID " + txtStudentID .Text + "doesn't exist");
                ClearTextBoxes();

            }
            else
            {
                MessageBox.Show("Student found successfully.");
                txtFirstName.Text = studentDT.Rows[0]["firstName"].ToString();
                txtLastName.Text = studentDT.Rows[0]["lastName"].ToString();
                txtAddress2.Text = studentDT.Rows[0]["address2"].ToString();
                txtAddress1.Text = studentDT.Rows[0]["address1"].ToString();
                txtSuburb.Text = studentDT.Rows[0]["suburb"].ToString();
                lstState.SelectedItem = studentDT.Rows[0]["state"].ToString();
                txtPostCode.Text = studentDT.Rows[0]["postcode"].ToString();
                txtEmail.Text = studentDT.Rows[0]["email"].ToString();
                txtContactNumber.Text = studentDT.Rows[0]["contactNo"].ToString();
                btnEdit.Enabled = true;
            }
        }
        private void ClearTextBoxes()
        {
            txtStudentID.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtContactNumber.Text = "";
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPostCode.Text = "";
            txtStudentID.Text = "";
            txtSuburb.Text = "";
            txtStudentID.Focus();
            btnEdit.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Validates inputs for mandatory fields and correct type of data.
        private bool ValidateInputs()
        {
            
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("First Name can't be null.");
                txtFirstName.Focus();
                return false;
            }
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Last Name can't be null.");
                txtLastName.Focus();
                return false;
            }
            if (txtAddress1.Text == "")
            {
                MessageBox.Show("Address Line 1 can't be null.");
                txtAddress1.Focus();
                return false;
            }
            if (txtSuburb.Text == "")
            {
                MessageBox.Show("Suburb can't be null.");
                txtSuburb.Focus();
                return false;
            }
            if (txtPostCode.Text == "")
            {
                MessageBox.Show("Post Code can't be null.");
                txtPostCode.Focus();
                return false;
            }
            try
            {
                int.Parse(txtPostCode.Text);
            }
            catch
            {
                MessageBox.Show("Accepts only integer number as a postcode.");
                txtPostCode.Text = "";
                txtPostCode.Focus();
                return false;
            }
            return true;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() == false) return;
           
            Student studentToEdit = new Student();
            studentToEdit.StudentID = int.Parse(txtStudentID.Text );
            studentToEdit.FirstName = txtFirstName.Text;
            studentToEdit.LastName = txtLastName.Text;
            studentToEdit.Address1 = txtAddress1.Text;
            studentToEdit.Address2 = txtAddress2.Text;
            studentToEdit.Suburb = txtSuburb.Text;
            studentToEdit.State = lstState.SelectedItem.ToString();
            studentToEdit.PostCode =int.Parse(txtPostCode.Text);
            studentToEdit.Email = txtEmail.Text;
            studentToEdit.ContactNumber = txtContactNumber.Text;

            int recordEdited = studentToEdit.EditStudent();
            if (recordEdited == 0)
            {
                MessageBox.Show("Update Operation failed. Check the values provided and try again.");
            }
            else
            {
                MessageBox.Show("Student updated successfully.");
                ClearTextBoxes();
            }
        }

        private void EditStudentForm_Load(object sender, EventArgs e)
        {
            txtStudentID.Focus();
        }
    }
}
