using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Console
{
    public class Person
    {
        //fields
        private readonly int personID;
        public int PersonID { get { return personID; } }

        private string firstName;
        public string FirstName
        { //property of firstname
            get { return firstName; }
            set
            {
                if (value == null) // if value is empty or value is null throw exeption
                {
                    throw new ArgumentNullException();
                }
                else if (value.Equals(""))
                {
                    throw new ArgumentException("Person needs to have a valid first name.");
                }
                else { firstName = value; }
            }
        }
        private string lastName;
        public string LastName
        { //property of lastname
            get { return lastName; }
            set
            {
                if (value == null) // if value is empty or value is null throw exeption
                {
                    throw new ArgumentNullException();
                }
                else if (value.Equals(""))
                {
                    throw new ArgumentException("Person needs to have a valid last name.");
                }
                else { lastName = value; }
            }
        }

        public Person() //Constructor
        {
            firstName = "Firstname";
            lastName = "Lastname";
            personID = 0;
        }
    }
}
