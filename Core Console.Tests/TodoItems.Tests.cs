using System;
using System.Collections.Generic;
using System.Text;
using Core_Console;
using Xunit;

namespace Core_Console.Tests
{
    
    public class TodoItemstests
    {
        TodoItems todoArray = new TodoItems();
        [Fact]
        public void TodoItemsTest()
        {
            //arrange
            int excpectedArraySize = 4; //testing adding 4 todo to slot [0] [1] [2] [3] (while 0 is starting pos)
            int excpectedTodoID1 = 1;
            string excpectedDescription1 = "Clean"; //clean is todoitem 1
            int excpectedTodoID2 = 3; // wash is todo item 3
            string excpectedDescription2 = "Wash";
            string expectedName = "Albin";
            int expectedTrueLenght = 1;
            int expectedFalseLenght = 3;
            string expectedUnassignedTodo = "Dance"; 

            //act
            todoArray.AddTodoToArray(1, "Clean"); // array slot 0
            todoArray.AddTodoToArray(2, "Vaccum"); // array slot 1
            todoArray.AddTodoToArray(3, "Wash"); // array slot 2
            todoArray.AddTodoToArray(4, "Dance"); // array slot 3
            Person pers = new Person("Albin", "de Val");
            Person pers2 = new Person("Håkan", "Hellström");
            Person pers3 = new Person("Martin", "Martinsson");
            todoArray.FindById(1).Assignee = pers; // asigning our 3 persons to our 3 todo taks
            todoArray.FindById(2).Assignee = pers2;
            todoArray.FindById(3).Assignee = pers3;
            todoArray.FindById(1).Done = true;  //Setting one todo to True, other 2 should be false (as per their starting value)

            //assert 

            //FindBYid tests
            Assert.Equal(todoArray.FindById(1).TodoID, excpectedTodoID1);  //checking if person 1 is saved to correct array slot
            Assert.Equal(todoArray.FindById(1).Description, excpectedDescription1);
            Assert.Equal(todoArray.FindById(3).TodoID, excpectedTodoID2);  //checking if person 3 is saved to correct array slot
            Assert.Equal(todoArray.FindById(3).Description, excpectedDescription2);

            //Size tests
            Assert.Equal(todoArray.Size(), excpectedArraySize); // checking if size of array is correct
            //FindbyDone test
            Assert.Equal(todoArray.FindByDoneStatus(true).Length, expectedTrueLenght); //testing size of arrays (true should be size 1 and false 3)
            Assert.Equal(todoArray.FindByDoneStatus(false).Length, expectedFalseLenght);
            //find by assigne tests
            Assert.Equal(todoArray.FindByAssignee(1)[0].Assignee.FirstName, expectedName);
            Assert.Equal(todoArray.FindByAssignee(pers)[0].Assignee.FirstName, expectedName);
            //FindUnassignedTodoItems tests
            Assert.Equal(todoArray.FindUnassignedTodoItems()[0].Description, expectedUnassignedTodo); //dance should not be assigned to any person

        }
    }
}
