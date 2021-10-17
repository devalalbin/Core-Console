using System;
using System.Collections.Generic;
using System.Text;
using Core_Console;
using Xunit;

namespace Core_Console.Tests
{

    public class PeopleTests
    {
        [Fact]
        public void PeopleTest() 
        {
            //arrange
            int excpectedArraySize = 3; //testing adding 3 persons to slots [0] [1] [2] 
            string expectedFirstName1 = "Zlatan";
            string excpectedLastName1 = "Ibrahimovic";
            string expectedFirstName2 = "Cristiano";
            string excpectedLastName2 = "Ronaldo";

            //act
            People peopleArray = new People();
            peopleArray.AddPersonToArray("Zlatan", "Ibrahimovic"); // array slot 1
            peopleArray.AddPersonToArray("Leo", "Messi"); // array slot 2
            peopleArray.AddPersonToArray("Cristiano", "Ronaldo"); // array slot 2
            Console.WriteLine(peopleArray.Size());

            //assert 
            Assert.Equal(peopleArray.FindById(1).FirstName, expectedFirstName1);  //checking if person 1 is saved to correct array slot
            Assert.Equal(peopleArray.FindById(1).LastName, excpectedLastName1);

            Assert.Equal(peopleArray.FindById(3).FirstName, expectedFirstName2);  //checking if person 3 is saved to correct array slot
            Assert.Equal(peopleArray.FindById(3).LastName, excpectedLastName2);
            Assert.Equal(peopleArray.Size(), excpectedArraySize); // checking if size of array is correct
            //FindAll test
            Assert.Equal(peopleArray.FindAll()[2].FirstName, expectedFirstName2);  //person in arrayslot [2] should be cristiano when returning all
        }


    }
}
