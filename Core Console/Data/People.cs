using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Console
{
    public class People
    {
        private static Person[] personArray = new Person[0]; //array of persons
        int iD = 0; //setting person starting spot to 1


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
            for(int i = 0; i < personArray.Length; i++)
            {
                if(personArray[i].PersonID == personId) //if person with ID exists return that person
                {
                    return personArray[i];
                }
                
            }
            return null;

        }
        public void AddPersonToArray(string firstName, string lastName) //creates a new person and adds it to the person array
        {
             // get next person id
            Array.Resize(ref personArray, iD+1); //expanding the array (id+1 cause of the array start on 0 so the Size matches)
            Person newPerson = new Person(firstName, lastName); //adding a person to the iD spot
            personArray[iD] = newPerson;
            iD++;
        }
        public void Clear()
        {
            Array.Clear(personArray, 0, personArray.Length);
            Array.Resize(ref personArray, 0);
        }
    }
}
