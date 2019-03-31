using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace TaxCalculator
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        ArrayList people = new ArrayList();

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            // check if ID is correct length
            if (txtEmployeeID.Text.Length != 5)
            {
                MessageBox.Show("Please enter an ID that starts with 'E' for employee, followed by 4 digits that is greater than 1000.");
            }
            else
            {
                int value1;
                float value2;
                // make sure ID begins with E for employee
                if (Char.ToUpper(txtEmployeeID.Text[0]) != 'E')
                {
                    MessageBox.Show("Employee ID must start with either 'E' for employee.");
                }
                // check if last four characters are digits
                else if (!int.TryParse(txtEmployeeID.Text.Substring(1), out value1))
                {
                    MessageBox.Show("Last four characters must be digits");
                }
                // check that ID is greater than 1000
                else if (int.Parse(txtEmployeeID.Text.Substring(1)) < 1000)
                {
                    MessageBox.Show("Last four digits must be from 1000 and above");
                }
                // check if first name is empty
                else if (txtFirstName.Text.Equals(null) || txtFirstName.Text.Equals(""))
                {
                    MessageBox.Show("Please enter a first name");
                }
                // check if last name is empty
                else if (txtSurname.Text.Equals(null) || txtSurname.Text.Equals(""))
                {
                    MessageBox.Show("Please enter a surname");
                }
                // check if department is empty
                else if (cboDepartment.Text.Equals(""))
                {
                    MessageBox.Show("Please select a department");
                }
                // check if email is empty or does not contain the @ symbol
                else if (txtEmail.Text.Equals(null) || txtEmail.Text.Equals("") || !txtEmail.Text.Contains("@"))
                {
                    MessageBox.Show("Please enter an email address");
                }
                // check if hourly rate is a float
                else if (!float.TryParse(txtHourlyRate.Text, out value2))
                {
                    MessageBox.Show("Hourly rate must be numeric");
                }
                else
                {
                    // create variable to hold gender value
                    String gender = "M";
                    if (rbFemale.Checked)
                    {
                        gender = "F";
                    }
                    // create new employee and add it to the people array
                    Employee employee = new TaxCalculator.Employee();
                    employee.createEmployee(employee, txtEmployeeID.Text, txtFirstName.Text, txtSurname.Text, gender,
                        txtEmail.Text, cboDepartment.Text, float.Parse(txtHourlyRate.Text));
                    people.Add(employee);
                    // display all employee details in text box
                    txtDisplay.Text = "Employee ID: " + employee.EmployeeID + "\r\n";
                    txtDisplay.Text += "Full Name: " + employee.FirstName + " " + employee.Surname + "\r\n";
                    txtDisplay.Text += "Gender: " + employee.Gender + "\r\n";
                    txtDisplay.Text += "Department: " + employee.Department + "\r\n";
                    txtDisplay.Text += "Email: " + employee.Email + "\r\n";
                    txtDisplay.Text += "Hourly rate: " + employee.HourlyRate;

                    btnCalculateEmpTax.Enabled = true;
                    btnCalculateConTax.Enabled = false;
                }
            }
        }

        private void btnCreateContractor_Click(object sender, EventArgs e)
        {
            // check if ID is correct length
            if (txtEmployeeID.Text.Length != 5)
            {
                MessageBox.Show("Please enter an ID that starts with 'C' for contractor, followed by 4 digits that is greater than 1000.");
            }
            else
            {
                int value1;
                float value2;
                // make sure ID begins with C for contractor
                if (char.ToUpper(txtEmployeeID.Text[0]) != 'C')
                {
                    MessageBox.Show("Employee ID must start with either 'C' for contractor.");
                }
                // check if last four characters are digits
                else if (!int.TryParse(txtEmployeeID.Text.Substring(1), out value1))
                {
                    MessageBox.Show("Last four characters must be digits");
                }
                // check that ID is greater than 1000
                else if (int.Parse(txtEmployeeID.Text.Substring(1)) < 1000)
                {
                    MessageBox.Show("Last four digits must be from 1000 and above");
                }
                // check if first name is empty
                else if (txtFirstName.Text.Equals(null) || txtFirstName.Text.Equals(""))
                {
                    MessageBox.Show("Please enter a first name");
                }
                // check if last name is empty
                else if (txtSurname.Text.Equals(null) || txtSurname.Text.Equals(""))
                {
                    MessageBox.Show("Please enter a surname");
                }
                // check if department is empty
                else if (cboDepartment.Text.Equals(""))
                {
                    MessageBox.Show("Please select a department");
                }
                // check if email is empty or does not contain the @ symbol
                else if (txtEmail.Text.Equals(null) || txtEmail.Text.Equals("") || !txtEmail.Text.Contains("@"))
                {
                    MessageBox.Show("Please enter an email address");
                }
                // check if hourly rate is a float
                else if (!float.TryParse(txtHourlyRate.Text, out value2))
                {
                    MessageBox.Show("Hourly rate must be numeric");
                }
                // check if hoursWorked is empty
                else if (txtHoursWorked.Text.Equals(null) || txtHoursWorked.Text.Equals(""))
                {
                    MessageBox.Show("Please enter hours worked");
                }
                else
                {
                    // create variable to hold gender value
                    String gender = "M";
                    if (rbFemale.Checked)
                    {
                        gender = "F";
                    }
                    // create new contractor and add it to the people array
                    Contractor contractor = new TaxCalculator.Contractor();
                    contractor.createContractor(contractor, txtEmployeeID.Text, txtFirstName.Text, txtSurname.Text, gender,
                        txtEmail.Text, cboDepartment.Text, float.Parse(txtHourlyRate.Text), float.Parse(txtHoursWorked.Text));
                    people.Add(contractor);

                    // display all employee details in text box
                    txtDisplay.Text = "Employee ID: " + contractor.EmployeeID + "\r\n";
                    txtDisplay.Text += "Full Name: " + contractor.FirstName + " " + contractor.Surname + "\r\n";
                    txtDisplay.Text += "Gender: " + contractor.Gender + "\r\n";
                    txtDisplay.Text += "Department: " +contractor.Department + "\r\n";
                    txtDisplay.Text += "Email: " + contractor.Email + "\r\n";
                    txtDisplay.Text += "Hourly rate: " + contractor.HourlyRate + "\r\n";
                    txtDisplay.Text += "Hours worked: " + contractor.HoursWorked;

                    btnCalculateConTax.Enabled = true;
                    btnCalculateEmpTax.Enabled = false;
                }
            }
        }

        // display Rates.txt file location selection on start up
        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            MessageBox.Show("*Please select the tax rates text file location*");
            // set up file dialog default settings
            openFileDialog1.Title = "Tax rates file location";
            openFileDialog1.FileName = "Rates.txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            lblHoursWorked.Visible = false;
            txtHoursWorked.Visible = false;

            txtEmployeeID.Text = "e1234";
            txtFirstName.Text = "Stefan";
            txtSurname.Text = "Maz";
            cboDepartment.SelectedIndex = 0;
            txtEmail.Text = "snoofo@hotmail.com";
            txtHourlyRate.Text = "20";
        }

        private void txtEmployeeID_Leave(object sender, EventArgs e)
        {
            // make hours worked only visible if first character of employeeID is 'C'
            if (!txtEmployeeID.Text.Equals(""))
            {
                if (Char.ToUpper(txtEmployeeID.Text[0]) == 'C')
                {
                    lblHoursWorked.Visible = true;
                    txtHoursWorked.Visible = true;
                }
                else
                {
                    lblHoursWorked.Visible = false;
                    txtHoursWorked.Visible = false;
                }
            }
            else
            {
                lblHoursWorked.Visible = false;
                txtHoursWorked.Visible = false;
            }
        }

        // helper method to return array of tax brackets
        private string[] readTaxBrackets(string filePath)
        {
            string[] textLines = File.ReadAllLines(filePath);
            // extract first line of text into an array
            string[] textLine1 = textLines[0].Split(',');

            return textLine1;
        }

        // helper method to return array of tax rates
        private string[] readTaxRates(string filePath)
        {
            string[] textLines = File.ReadAllLines(filePath);
            // extract second line of text into an array
            string[] textLine2 = textLines[1].Split(',');

            return textLine2;
        }

        private void btnCalculateEmpTax_Click(object sender, EventArgs e)
        {
            string filePath = openFileDialog1.FileName;
            // create arrays with helper methods
            string[] taxBrackets = readTaxBrackets(filePath);
            string[] taxRates = readTaxRates(filePath);

            try
            {
                // convert string arrays to float arrays
                float[] taxBracketValues = Array.ConvertAll(taxBrackets, float.Parse);
                float[] taxRateValues = Array.ConvertAll(taxRates, float.Parse);

                float hourlyRate, salary, tax = 0;

                // make sure value entered is numeric
                try
                {
                    hourlyRate = ((Employee)people[people.Count - 1]).HourlyRate;
                    // calculate salary and tax
                    salary = hourlyRate * 40;
                    float salaryLeft;
                    if (salary <= taxBracketValues[0])
                    {
                        tax = salary * taxRateValues[0];
                    }
                    else if (salary <= taxBracketValues[1])
                    {
                        tax = taxBracketValues[0] * taxRateValues[0];
                        salaryLeft = salary - taxBracketValues[0];
                        tax += salaryLeft * taxRateValues[1];
                    }
                    else if (salary <= taxBracketValues[2])
                    {
                        tax = taxBracketValues[0] * taxRateValues[0];
                        salaryLeft = salary - taxBracketValues[0];
                        tax += (taxBracketValues[1] - taxBracketValues[0]) * taxRateValues[1];
                        salaryLeft -= (taxBracketValues[1] - taxBracketValues[0]);
                        tax += salaryLeft * taxRateValues[2];
                    }
                    else if (salary <= taxBracketValues[3])
                    {
                        tax = taxBracketValues[0] * taxRateValues[0];
                        salaryLeft = salary - taxBracketValues[0];
                        tax += (taxBracketValues[1] - taxBracketValues[0]) * taxRateValues[1];
                        salaryLeft -= (taxBracketValues[1] - taxBracketValues[0]);
                        tax += (taxBracketValues[2] - taxBracketValues[1]) * taxRateValues[2];
                        salaryLeft -= (taxBracketValues[2] - taxBracketValues[1]);
                        tax += salaryLeft * taxRateValues[3];
                    }
                    else
                    {
                        tax = taxBracketValues[0] * taxRateValues[0];
                        salaryLeft = salary - taxBracketValues[0];
                        tax += (taxBracketValues[1] - taxBracketValues[0]) * taxRateValues[1];
                        salaryLeft -= (taxBracketValues[1] - taxBracketValues[0]);
                        tax += (taxBracketValues[2] - taxBracketValues[1]) * taxRateValues[2];
                        salaryLeft -= (taxBracketValues[2] - taxBracketValues[1]);
                        tax += (taxBracketValues[3] - taxBracketValues[2]) * taxRateValues[3];
                        salaryLeft -= (taxBracketValues[3] - taxBracketValues[2]);
                        tax += salaryLeft * taxRateValues[4];
                    }

                    txtDisplay.Text = "Employee ID: " + ((Employee)people[people.Count - 1]).EmployeeID + "\r\n"
                        + "Salary: " + salary + "\r\n" + "Tax: " + tax;

                    // save information to PDF
                    saveFileDialog1.Title = "Save PDF";
                    saveFileDialog1.FileName = txtEmployeeID.Text + ".pdf";
                    saveFileDialog1.Filter = "PDF files *.pdf| *.pdf";
                    saveFileDialog1.ShowDialog();

                    FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                    Document doc = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();
                    Chunk c1 = new Chunk("Employee ID: " + ((Employee)people[people.Count - 1]).EmployeeID);
                    Chunk c2 = new Chunk("Full name: " + ((Employee)people[people.Count - 1]).FirstName + " " + ((Employee)people[people.Count - 1]).Surname);
                    Chunk c3 = new Chunk("Department: " + ((Employee)people[people.Count - 1]).Department);
                    Chunk c4 = new Chunk("Gross salary: " + salary.ToString());
                    Chunk c5 = new Chunk("Tax: " + tax.ToString());
                    Paragraph paragraph = new Paragraph(c1 + "\n" + c2 + "\n" + c3 + "\n" + c4 + "\n" + c5);
                    doc.Add(paragraph);
                    doc.Close();
                    writer.Close();
                    fs.Close();

                    btnCalculateEmpTax.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hourly rate must be numeric");
                }
                finally
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Values recieved from Rates text file were not numeric");
            }

        }

        private void btnCalculateConTax_Click(object sender, EventArgs e)
        {
            float hourlyRate, hoursWorked, salary, tax;

            // make sure values entered are numeric
            try
            {
                hourlyRate = ((Contractor)people[people.Count - 1]).HourlyRate;
                try
                {
                    hoursWorked = ((Contractor)people[people.Count - 1]).HoursWorked;
                    // calculate salary and tax
                    salary = hoursWorked * hourlyRate;
                    tax = salary * Contractor.TaxRate;

                    txtDisplay.Text = "Employee ID: " + ((Contractor)people[people.Count - 1]).EmployeeID + "\r\n"
                        + "Salary: " + salary + "\r\n" + "Tax: " + tax;

                    // save information to PDF
                    saveFileDialog1.Title = "Save PDF";
                    saveFileDialog1.FileName = txtEmployeeID.Text + ".pdf";
                    saveFileDialog1.Filter = "PDF files *.pdf| *.pdf";
                    saveFileDialog1.ShowDialog();

                    FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                    Document doc = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();
                    Chunk c1 = new Chunk("Employee ID: " + ((Contractor)people[people.Count - 1]).EmployeeID);
                    Chunk c2 = new Chunk("Full name: " + ((Contractor)people[people.Count - 1]).FirstName + " " + ((Contractor)people[people.Count - 1]).Surname);
                    Chunk c3 = new Chunk("Department: " + ((Contractor)people[people.Count - 1]).Department);
                    Chunk c4 = new Chunk("Gross salary: " + salary.ToString());
                    Chunk c5 = new Chunk("Tax: " + tax.ToString());
                    Paragraph paragraph = new Paragraph(c1 + "\n" + c2 + "\n" + c3 + "\n" + c4 + "\n" + c5);
                    doc.Add(paragraph);
                    doc.Close();
                    writer.Close();
                    fs.Close();

                    btnCalculateConTax.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hours worked must be numeric");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hourly rate must be numeric");
            }
            
        }

        //private void txtEmployeeID_Leave(object sender, EventArgs e)
        //{
        //    txtDisplay.Text = "Hello";
        //}
    }
}
