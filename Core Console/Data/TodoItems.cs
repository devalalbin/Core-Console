using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Console
{
    public class TodoItems
    {
        private static Todo[] todoArray = new Todo[0]; //array of todos
        private Todo[] methodArray = new Todo[0]; //array to use in methods
        int iD = 0;


        public int Size() // returns lenght of todo array
        {
            return todoArray.Length;
        }
        public Todo[] FindAll() // returns the todo array
        {
            return todoArray;
        }
        public Todo FindById(int todoID) // returns the specific todo with that ID
        {
            for (int i = 0; i <= todoArray.Length; i++)
            {
                if (todoArray[i].TodoID == todoID) //if person with ID exists return that person
                {
                    return todoArray[i];
                }
            }
            return null; 
        }
        public void AddTodoToArray(int todoID, string description) //creates a new todo and adds it to the todo array 
        {
            //int iD = TodoSequencer.NextTodoID(); // get next todo id
            Array.Resize(ref todoArray, iD + 1); //expanding the array (id+1 cause of the array start on 0 so the Size matches)
            Todo newTodo = new Todo(todoID, description); //adding a todo to the iD spot
            todoArray[iD] = newTodo;
            iD++;
        }
        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            int Count = 0;
            for(int i = 0; i< todoArray.Length; i++) //step through the array to se what todo items have a matching done status
            {
                if (doneStatus == todoArray[i].Done)
                {
                    Array.Resize(ref methodArray, Count+1); //expanding the array 
                    methodArray[Count] = todoArray[i];
                    Count++;  // adding matching status into new array starting at slot 1
                } 
            }
            return methodArray;
        }
        public Todo[] FindByAssignee(int personId)
        {
            int Count = 0;
            for (int i = 0; i < todoArray.Length; i++) //step through the array to se what todo items have a matching person ID
            {
                if (personId == todoArray[i].Assignee.PersonID)
                {
                    Array.Resize(ref methodArray, Count + 1); //expanding the array 
                    methodArray[Count] = todoArray[i];
                    Count++;  // adding matching status into new array starting at slot 1
                }
            }
            return methodArray;
        }
        public Todo[] FindByAssignee(Person assignee)
        {
            int Count = 0;
            for (int i = 0; i < todoArray.Length; i++) //step through the array to se what todo items have a matching person
            {
                if (assignee == todoArray[i].Assignee)
                {
                    Array.Resize(ref methodArray, Count + 1); //expanding the array 
                    methodArray[Count] = todoArray[i];
                    Count++;  // adding matching status into new array starting at slot 1
                }
            }
            return methodArray;
        }
        public Todo[] FindUnassignedTodoItems()
        {
            int Count = 0;
            for (int i = 0; i < todoArray.Length; i++) //step through the array to se what todo items have a matching person
            {
                if (todoArray[i].Assignee.FirstName == null)
                {
                    Array.Resize(ref methodArray, Count + 1); //expanding the array 
                    methodArray[Count] = todoArray[i];
                    Count++;  // adding matching status into new array starting at slot 1
                }
            }
            return methodArray;
        }
        public void Clear()
        {
            Array.Clear(todoArray, 0, todoArray.Length);
            Array.Resize(ref todoArray, 0);
        }
    }
}
