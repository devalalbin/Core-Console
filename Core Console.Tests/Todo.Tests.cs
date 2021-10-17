using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Core_Console.Tests
{
    public class TodoTests
    {
        [Fact]
        public void TodoConstructorTest() // Testing our Constructor of Todo class if it accepts our values
        {
            int id = 1;
            string descript = "Todo Test";

            Todo testTodo = new Todo(id,descript); //checking if the inputs are correct

            Assert.NotNull(testTodo);
            Assert.Equal(testTodo.Description, descript); 
            Assert.Equal(testTodo.TodoID, id);
           
        }
    }
}
