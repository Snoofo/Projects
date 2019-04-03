using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme_Insurance.Business_Logic_Layer
{
    class Customer
    {
        private int customerID, categoryID, postcode;
        private string firstName, lastName, address, suburb, state, gender;
        private DateTime birthDate;

        public Customer() { }

        public Customer(int customerID, int categoryID, string firstName, string lastName,
            string address, string suburb, string state, int postcode, string gender, DateTime birthDate)
        {
            CustomerID = customerID;
            CategoryID = categoryID;
            Postcode = postcode;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Suburb = suburb;
            State = state;
            Gender = gender;
            BirthDate = birthDate;
        }

        public int CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
            }
        }

        public int CategoryID
        {
            get
            {
                return categoryID;
            }
            set
            {
                categoryID = value;
            }
        }

        public int Postcode
        {
            get
            {
                return postcode;
            }
            set
            {
                postcode = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string Suburb
        {
            get
            {
                return suburb;
            }
            set
            {
                suburb = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }

    }
}
