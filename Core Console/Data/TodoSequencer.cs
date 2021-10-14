using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Console
{
    public class TodoSequencer
    {
        private static int todoId;

        public TodoSequencer()
        {
            todoId = 0;
        }
        public static int NextTodoID() //Increments todo and returns next id
        {
            todoId++;
            return todoId;
        }
        public static void Reset() //reset todo to 0
        {
            todoId = 0;
        }

    }
}
