using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Console
{
    public class TodoItems
    {
        private static Todo[] todoArray = new Todo[0]; //array of todos


        public int Size() // returns lenght of todo array
        {
            return todoArray.Length;
        }
        public Todo[] FindAll() // returns the todo array
        {
            return todoArray;
        }
        public Todo FindById(int personId) // returns the specific todo with that ID
        {
            return todoArray[personId];
        }
        public void AddTodoToArray(int todoID, string description) //creates a new todo and adds it to the todo array
        {
            int iD = TodoSequencer.NextTodoID(); // get next todo id
            Array.Resize(ref todoArray, iD + 1); //expanding the array (id+1 cause of the array start on 0 so the Size matches)
            Todo newTodo = new Todo(todoID, description); //adding a todo to the iD spot
            todoArray[iD] = newTodo;
        }
    }
}
