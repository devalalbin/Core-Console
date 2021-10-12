using System;
using Core_Console;

namespace Core_Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person pers = new Person();
            pers.FirstName = "Albin";
            pers.LastName = "de Val";
            //pers.FirstName = "";
            //pers.LastName = null;
            Console.WriteLine(pers.FirstName);
            Console.WriteLine(pers.LastName);
            Console.WriteLine(pers.PersonID);
        }
    }
}
