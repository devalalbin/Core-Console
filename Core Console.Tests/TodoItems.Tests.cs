using System;
using System.Collections.Generic;
using System.Text;
using Core_Console;
using Xunit;

namespace Core_Console.Tests
{

    public class TodoItemstests
    {
        [Fact]
        public void TodoItemsTest()
        {
            //arrange
            int excpectedArraySize = 4; //testing adding 3 persons to slot [1] [2] [3] (while 0 is starting pos)
            int excpectedTodoID1 = 1;
            string excpectedDescription1 = "Clean"; //clean is todoitem 1

            int excpectedTodoID2 = 3; // wash is todo item 3
            string excpectedDescription2 = "Wash";


            //act
            TodoItems todoArray = new TodoItems();
            todoArray.AddTodoToArray(1, "Clean"); // array slot 1
            todoArray.AddTodoToArray(2, "Vaccum"); // array slot 2
            todoArray.AddTodoToArray(3, "Wash"); // array slot 2
            Console.WriteLine(todoArray.Size());

            //assert 
            Assert.Equal(todoArray.FindById(1).TodoID, excpectedTodoID1);  //checking if person 1 is saved to correct array slot
            Assert.Equal(todoArray.FindById(1).Description, excpectedDescription1);

            Assert.Equal(todoArray.FindById(3).TodoID, excpectedTodoID2);  //checking if person 3 is saved to correct array slot
            Assert.Equal(todoArray.FindById(3).Description, excpectedDescription2);
            Assert.Equal(todoArray.Size(), excpectedArraySize); // checking if size of array is correct

        }


    }
}
