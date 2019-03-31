using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class Contractor : Employee
    {
        private float hoursWorked;
        private static float taxRate = 0.2F;

        public Contractor createContractor(Contractor contractor, string employeeID, string firstName,
            string surname, string gender, string email, string department, float hourlyRate, float hoursWorked)
        {
            contractor.EmployeeID = employeeID;
            contractor.FirstName = firstName;
            contractor.Surname = surname;
            contractor.Gender = gender;
            contractor.Email = email;
            contractor.Department = department;
            contractor.HourlyRate = hourlyRate;
            contractor.HoursWorked = hoursWorked;
            return contractor;
        }

        
        public override float calculateTax()
        {
            float tax;
            tax = 0;
            return tax;
        }
        
        public static float TaxRate
        {
            get
            {
                return taxRate;
            }
            set
            {
                taxRate = value;
            }
        }

        public new float HoursWorked
        {
            get
            {
                return hoursWorked;
            }
            set
            {
                hoursWorked = value;
            }
        }
    }
}
