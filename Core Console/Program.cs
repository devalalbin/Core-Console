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

            PersonSequencer perSeq = new PersonSequencer();
            PersonSequencer perSeq2 = new PersonSequencer();
            PersonSequencer.Reset();
            TodoSequencer todoSeq = new TodoSequencer();

            People peeps = new People();
            peeps.AddPersonToArray("hej","då");
            peeps.AddPersonToArray("ny", "pers");
            
            Console.WriteLine(peeps.Size()+ peeps.FindById(1).FirstName);
        }
    }
}
