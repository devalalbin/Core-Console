using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Console
{
    public class PersonSequencer
    {
        private static int personId;

        public PersonSequencer()
        {
            personId = 0;
        }
        public static int NextPersonID() //add togehter two values
        {
            personId++;
            return personId;
        }
         public static void Reset() //add togehter two values
        {
            personId = 0;
        }

    }
}
