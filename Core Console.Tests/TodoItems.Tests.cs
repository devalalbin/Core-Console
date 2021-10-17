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
            //Arrange
            int excpectedArraySize = 4; //testing adding 4 todo to slot [0] [1] [2] [3] (while 0 is starting pos)
            int excpectedTodoID1 = 1;
            string excpectedDescription1 = "Clean"; //clean is todoitem 1
            int excpectedTodoID2 = 3; // wash is todo item 3
            string excpectedDescription2 = "Wash";
            string excpectedDescription3 = "Vaccum";
            int expectedTrueLenght = 1;
            int expectedFalseLenght = 3;
            string expectedUnassignedTodo = "Dance";

            //Act
            TodoItems todoArray = new TodoItems();
            todoArray.AddTodoToArray(1, "Clean"); // fill our todoArray with tasks
            todoArray.AddTodoToArray(2, "Vaccum"); 
            todoArray.AddTodoToArray(3, "Wash"); 
            todoArray.AddTodoToArray(4, "Dance"); 
            Person pers = new Person("Albin", "de Val");
            Person pers2 = new Person("Håkan", "Hellström");
            Person pers3 = new Person("Martin", "Martinsson");
            todoArray.FindById(1).Assignee = pers; // asigning our 3 persons to our 3 todo taks
            todoArray.FindById(2).Assignee = pers2;
            todoArray.FindById(3).Assignee = pers3;
            todoArray.FindById(1).Done = true;  //Setting one todo to True, other 2 should be false (as per their starting value)

            //Assert 

            //FindBYid tests
            Assert.Equal(todoArray.FindById(1).TodoID, excpectedTodoID1);  //checking if person 1 is saved to correct array slot
            Assert.Equal(todoArray.FindById(1).Description, excpectedDescription1);
            Assert.Equal(todoArray.FindById(3).TodoID, excpectedTodoID2);  //checking if person 3 is saved to correct array slot
            Assert.Equal(todoArray.FindById(3).Description, excpectedDescription2);

            //Size tests
            Assert.Equal(todoArray.Size(), excpectedArraySize); // checking if size of array is correct should be 4 slots big
            //FindbyDone test
            Assert.Equal(todoArray.FindByDoneStatus(true).Length, expectedTrueLenght); //testing size of arrays (true should be size 1 and false 3)
            Assert.Equal(todoArray.FindByDoneStatus(false).Length, expectedFalseLenght);
            //find by assigne tests
            Assert.Equal(todoArray.FindByAssignee(1)[0].Description, excpectedDescription1); //User id 1 = "albin de val" is assigned to "clean" in array slot [0]
            Assert.Equal(todoArray.FindByAssignee(pers)[0].Description, excpectedDescription1); // "pers" assigne = albin de val assigned to "clean"
            //FindUnassignedTodoItems tests
            Assert.Equal(todoArray.FindUnassignedTodoItems()[0].Description, expectedUnassignedTodo); //dance should not be assigned to any person
            //RemoveObjectFromArray tests
            todoArray.RemoveObjectFromArray(0); //removing "clean" from array size should go from 4 to 3
            Assert.Equal(todoArray.Size(), excpectedArraySize-1);
            Assert.Equal(todoArray.FindAll()[0].Description, excpectedDescription3); //checking that Vaccum moved from [1] to [0]
        }
    }
}