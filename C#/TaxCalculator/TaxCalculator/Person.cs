using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class Person
    {
        private string firstName;
        private string surname;
        private string gender;

        public Person createPerson(Person person, string firstname, string surname, string gender)
        {
            person.FirstName = firstname;
            person.Surname = surname;
            person.Gender = gender;
            return person;
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

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
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

    }
}
