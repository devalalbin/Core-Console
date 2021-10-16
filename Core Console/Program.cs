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
            TodoItems todoTests = new TodoItems();
            todoTests.AddTodoToArray(1, "tjena tjena");
            todoTests.AddTodoToArray(2, "hej tjena");
            todoTests.AddTodoToArray(3, "bla  bla");
            Console.WriteLine(todoTests.FindById(3).Description);


            Console.WriteLine(todoTests.FindById(3).Done);

            todoTests.FindById(2).Done = true;
            todoTests.FindByDoneStatus(false);
          

            Todo todo = new Todo(1, "hejhej");

            todo.Assignee = pers;
            todoTests.FindByAssignee(1);
            todoTests.FindUnassignedTodoItems();
            todoTests.FindByAssignee(pers);

        }
    }
}
