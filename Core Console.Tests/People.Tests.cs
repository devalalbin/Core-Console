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
            int excpectedArraySize = 4; //testing adding 3 persons to slot [1] [2] [3] (while 0 is starting pos)
            string excpectedName1 = "Zlatan";
            string excpectedName2 = "Ibrahimovic";
            string excpectedName3 = "Cristiano";
            string excpectedName4 = "Ronaldo";

            //act
            People peopleArray = new People();
            peopleArray.AddPersonToArray("Zlatan", "Ibrahimovic"); // array slot 1
            peopleArray.AddPersonToArray("Leo", "Messi"); // array slot 2
            peopleArray.AddPersonToArray("Cristiano", "Ronaldo"); // array slot 2
            Console.WriteLine(peopleArray.Size());

            //assert 
            Assert.Equal(peopleArray.FindById(1).FirstName, excpectedName1);  //checking if person 1 is saved to correct array slot
            Assert.Equal(peopleArray.FindById(1).LastName, excpectedName2);

            Assert.Equal(peopleArray.FindById(3).FirstName, excpectedName3);  //checking if person 3 is saved to correct array slot
            Assert.Equal(peopleArray.FindById(3).LastName, excpectedName4);
            Assert.Equal(peopleArray.Size(), excpectedArraySize); // checking if size of array is correct

        }


    }
}
