using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class Employee : Person
    {
        private string employeeID, department, email;
        private float hourlyRate;

        public Employee createEmployee(Employee employee, string employeeID, string firstName, string surname,
            string gender, string email, string department, float hourlyRate)
        {
            employee.employeeID = employeeID;
            employee.FirstName = firstName;
            employee.Surname = surname;
            employee.Gender = gender;
            employee.Email = email;
            employee.Department = department;
            employee.HourlyRate = hourlyRate;
            return employee;
        }

        public virtual float calculateTax()
        {
            float tax;
            tax = 0;
            return tax;
        }

        public string EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public float HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                hourlyRate = value;
            }
        }
    }
}
