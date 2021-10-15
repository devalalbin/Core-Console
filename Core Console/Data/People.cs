using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Console
{
    public class People
    {
        private static Person[] personArray = new Person[0]; //array of persons


        public int Size() // returns lenght of person array
        {
            return personArray.Length;
        }
        public Person[] FindAll() // returns the person array
        {
            return personArray;
        }
        public Person FindById(int personId) // returns the specific person with that ID
        {
            return personArray[personId];
        }
        public void AddPersonToArray(string firstName, string lastName) //creates a new person and adds it to the person array
        {
            int iD = PersonSequencer.NextPersonID(); // get next person id
            Array.Resize(ref personArray, iD+1); //expanding the array (id+1 cause of the array start on 0 so the Size matches)
            Person newPerson = new Person(firstName, lastName, iD); //adding a person to the iD spot
            personArray[iD] = newPerson;
        }
    }
}
