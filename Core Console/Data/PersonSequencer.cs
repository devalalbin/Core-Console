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
        public static int NextPersonID() //Increments personsequencer and returns next id
        {
            personId++;
            return personId;
        }
         public static void Reset() //reset person to 0
        {
            personId = 0;
        }

    }
}
