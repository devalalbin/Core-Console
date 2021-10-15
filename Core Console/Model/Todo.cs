using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Console
{
    public class Todo
    {
        //fields
        private readonly int todoID;
        public int TodoID { get { return todoID; } }
        private string description;
        public string Description { get { return description; } } 
        private bool done;
        private Person assignee = new Person();

       //constructor
        public Todo(int todoID, string description)
        {
            this.todoID = todoID;
            this.description = description;
            todoID++;
        }
    }
}
