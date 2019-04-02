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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtContactNo.Text = "";
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPostCode.Text = "";
            txtStudentID.Text = "";
            txtSuburb.Text = "";
            lstState.SelectedIndex = 0;
            txtStudentID.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //inserts a new student if user inputs are valid
        private void btnAddStudent_Click(object sender, EventArgs e)
        {            
            if (ValidateInputs() == false) return;
                       
            //creates a student object and assigns value to its variables as per user supplied data, only if it is a new record
            Student newStudent = new Student();
            if (ConnectionManager.GetTable("select * from Student where studentID="+txtStudentID.Text+"").Rows.Count!=0)
            {
                MessageBox.Show("Duplicate student ID is not allowed. Student record already exist or wrong student ID");
                txtStudentID.Focus();
                return;
            }
            newStudent.StudentID =int.Parse(txtStudentID.Text);
            newStudent.FirstName = txtFirstName.Text;
            newStudent.LastName = txtLastName.Text;
            newStudent.Address1 = txtAddress1.Text;
            newStudent.Address2 = txtAddress2.Text;
            newStudent.Suburb = txtSuburb.Text;
            newStudent.State = lstState.SelectedItem .ToString ();
            newStudent.PostCode = int.Parse(txtPostCode.Text);
            newStudent.ContactNumber = txtContactNo.Text;
            newStudent.Fine = 0.0;
            //call to AddNewStudent() method of Student class that will perform insertion of new record in Student table of database
            int recordAdded = newStudent.AddNewStudent();
            if (recordAdded != 0)
            {
                MessageBox.Show("Student inserted successfully.");
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Insertion Operation failed. Check the values provided and try again.");
            }
        }

        //Validates inputs for mandatory fields and correct type of data.
        private bool ValidateInputs()
        {
            if (txtStudentID .Text == "")
            {
                MessageBox.Show("Student ID can't be null.");
                txtStudentID.Focus();
                return false;
            }
            try
            {
                int.Parse(txtStudentID .Text);
            }
            catch
            {
                MessageBox.Show("Accepts only integer number as a student ID.");
                txtStudentID.Text = "";
                txtStudentID.Focus();
                return false;
            }

            if (txtFirstName.Text == "")
            {
                MessageBox.Show("First Name can't be null.");
                txtFirstName .Focus();
                return false;
            }
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Last Name can't be null.");
                txtLastName.Focus();
                return false;
            }
            if (txtAddress1 .Text == "")
            {
                MessageBox.Show("Address Line 1 can't be null.");
                txtAddress1.Focus();
                return false;
            }
            if (txtSuburb .Text == "")
            {
                MessageBox.Show("Suburb can't be null.");
                txtSuburb.Focus();
                return false;
            }
            if (txtPostCode .Text == "")
            {
                MessageBox.Show("Post Code can't be null.");
                txtPostCode.Focus();
                return false;
            }
            try
            {
                int.Parse(txtPostCode .Text);
            }
            catch
            {
                MessageBox.Show("Accepts only integer number as a postcodeD.");
                txtPostCode.Text = "";
                txtPostCode.Focus();
                return false;
            }
            return true;
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
