using System;
using System.Collections.Generic;
using System.Text;
using Core_Console;
using Xunit;

namespace Core_Console.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Constructor() // testing if our startingvalues of Person are correct
        {
            string firstName = "Firstname";
            string lastName = "Lastname";
            int personID = 0;

            Person testStudent = new Person();

            Assert.NotNull(testStudent);
            Assert.Equal(testStudent.FirstName, firstName);
            Assert.Equal(testStudent.LastName, lastName);
            Assert.Equal(testStudent.PersonID, personID);
        }
        [Fact]
        public void PersonNameEmptyCheck()
        {
            string emptyString = "";
            ArgumentException result = Assert.Throws<ArgumentException>(    //checking that if input is empty throw exception on first name
                () => new Person().FirstName = emptyString);

            Assert.Equal("Person needs to have a valid first name.", result.Message);
        }

        [Fact]
        public void PersonNameNULLCheck()
        {
            string nullString = null;
            ArgumentNullException result = Assert.Throws<ArgumentNullException>(    //checking that if input is NULL throw exception on lastname
                () => new Person().LastName = nullString);

            Assert.Equal("Value cannot be null.", result.Message);
        }
    }
}
