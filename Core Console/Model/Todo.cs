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
        public bool Done
        {
            get { return done; } 
            set { done = value; } //user can set task to either done or not done
        }
        private Person assignee = new Person();
        public Person Assignee //gets or sets a person to the Todo
         {
             get { return assignee; }
             set { assignee = value; } 
        }
       //constructor
        public Todo(int todoID, string description)
        {
            this.todoID = todoID;
            this.description = description;
            todoID++;
            done = false;
          
        }
    }
}
