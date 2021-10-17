using System;
using Core_Console;

namespace Core_Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //testing removeobject from People
            People peeps = new People(); 

            peeps.AddPersonToArray("Albin", "de Val");
            peeps.AddPersonToArray("Martin", "Martinsson");
            peeps.AddPersonToArray("Sven", "Svensson");
            peeps.AddPersonToArray("Jakob", "Jakobsson");
           
            Console.WriteLine("People Size before removal: "+peeps.Size());
            peeps.RemoveObjectFromArray(1); //removes Martin from array
            Console.WriteLine("People Size after removal: " + peeps.Size());
            peeps.Clear();

            //testing remove object from TodoItems
            TodoItems todoArray = new TodoItems();
            todoArray.AddTodoToArray(1, "Clean"); // array slot 0
            todoArray.AddTodoToArray(2, "Vaccum"); // array slot 1
            todoArray.AddTodoToArray(3, "Wash"); // array slot 2
            todoArray.AddTodoToArray(4, "Dance"); // array slot 3
            
            Console.WriteLine("Todoarray size before removal: " + todoArray.Size());
            todoArray.RemoveObjectFromArray(1); //removes Vaccum from array
            Console.WriteLine("Todoarray size after removal: " + todoArray.Size());
            
        }
    }
}
