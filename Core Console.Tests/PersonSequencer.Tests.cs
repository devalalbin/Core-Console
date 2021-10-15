using System;
using System.Collections.Generic;
using System.Text;
using Core_Console;
using Xunit;

namespace Core_Console.Tests
{
    
    public class PersonSequencerTests
    {
        [Fact]
        public void PersonSequenceTest() //Test of the ID increments
        {
            
            //arrange
            // Checking that the id sequence is working
            int expectedOne = 1;
            int expectedTwo = 2;
            int expectedThree = 3;
 
            //act
            PersonSequencer personSeqOne = new PersonSequencer(); //person id 0

            //asserts //using nextpersonID 1->2->3 then resetting to id 0
            Assert.Equal(PersonSequencer.NextPersonID(), expectedOne);   
            Assert.Equal(PersonSequencer.NextPersonID(), expectedTwo);
            Assert.Equal(PersonSequencer.NextPersonID(), expectedThree);
            PersonSequencer.Reset(); //reseting to ID to 0 
            Assert.Equal(PersonSequencer.NextPersonID(), expectedOne);
            

        }


    }
}
