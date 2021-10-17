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
        public void PersonTest() // testing if our startingvalues of Person are correct
        {
            // Arrange
            string expectedFirstName = "Albin";
            string expectedLastName = "de Val";

            //act
            Person testStudent = new Person("Albin", "de Val");

            //assert
            Assert.NotNull(testStudent);
            Assert.Equal(testStudent.FirstName, expectedFirstName);
            Assert.Equal(testStudent.LastName, expectedLastName);

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
