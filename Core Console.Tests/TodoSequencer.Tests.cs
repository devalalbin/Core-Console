using System;
using System.Collections.Generic;
using System.Text;
using Core_Console;
using Xunit;

namespace Core_Console.Tests
{

    public class TodoSequencerTests
    {
        [Fact]
        public void TodoSequencerTest() //Test of the ID increments
        {
            //arrange
            // Checking that the id sequence is working
            int expectedOne = 1;
            int expectedTwo = 2;
            int expectedThree = 3;

            //act
            TodoSequencer personOne = new TodoSequencer(); //todo id 0

            //asserts //using nextpersonID 1->2->3 then resetting to id 0
            Assert.Equal(TodoSequencer.NextTodoID(), expectedOne);
            Assert.Equal(TodoSequencer.NextTodoID(), expectedTwo);
            Assert.Equal(TodoSequencer.NextTodoID(), expectedThree);
            TodoSequencer.Reset(); //reseting to ID to 0 
            Assert.Equal(TodoSequencer.NextTodoID(), expectedOne);
            
        }


    }
}
