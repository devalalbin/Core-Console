using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Core_Console
{
    public class People
    {
        private static Person[] personArray = new Person[0]; //array of persons
        int iD = 0; 

        public int Size() // returns lenght of person array
        {
            return personArray.Length;
        }
        public Person[] FindAll() // returns the Person array
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
        public void Clear() //Clears the array
        {
            Array.Clear(personArray, 0, personArray.Length);
            Array.Resize(ref personArray, 0);
          // Console.WriteLine("Array after deletion");
            foreach (Person value in personArray)
            {
                Console.WriteLine(value.FirstName + " " + value.LastName); //should not write anything
            }
        }
        public void RemoveObjectFromArray(int indexToRemove)  
        {
            personArray = personArray.Where((source, index) => index != indexToRemove).ToArray(); //removes given person from the array (using the system linq libary and "Where")
            Console.WriteLine("Array after deletion: ");
            foreach(Person value in personArray)
            {
                Console.WriteLine(value.FirstName +" "+value.LastName);
            }
        }
    }
}
