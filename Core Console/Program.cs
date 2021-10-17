using System;
using Core_Console;

namespace Core_Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
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
            */
            /*
                        People peeps = new People();
                        peeps.AddPersonToArray("hej","då");
                        peeps.AddPersonToArray("ny", "pers");

                        Console.WriteLine(peeps.Size()+ peeps.FindById(1).FirstName);

                        Person pers = new Person("Albin","de Val");

                        Person pers2 = new Person("Håkan", "hellström");

                        Person pers3 = new Person("tobias", "devil");

                        Console.WriteLine(pers.PersonID);
                        Console.WriteLine(pers2.PersonID);
                        Console.WriteLine(pers3.PersonID);


                        TodoItems todoTests = new TodoItems();
                        todoTests.AddTodoToArray(1, "Dance");
                        todoTests.AddTodoToArray(2, "Jump");
                        //todoTests.FindById(2).Done = true;
                        todoTests.AddTodoToArray(3, "Hide");
                        Console.WriteLine(todoTests.FindById(3).Description);

                        todoTests.FindById(2).Assignee = pers;
                        Console.WriteLine(todoTests.FindById(2).Assignee.FirstName);

                        todoTests.FindById(1).Assignee = pers2;
                        Console.WriteLine(todoTests.FindById(1).Assignee.FirstName);
                        todoTests.FindById(3).Assignee = pers3;

                        //Assigne verkar inte funkera atm*********************************

                        //Console.WriteLine(todoTests.FindById(2).Done);

                        todoTests.FindById(2).Done = true;
                        todoTests.FindByDoneStatus(true);
                    */

            /*
            //todoTests.FindByAssignee(1);
            //todoTests.FindUnassignedTodoItems();
            //todoTests.FindByAssignee(pers);
            TodoItems todoArray = new TodoItems();


            //act
            //TodoItems todoArray = new TodoItems();
            todoArray.AddTodoToArray(1, "Clean"); // array slot 0
            todoArray.AddTodoToArray(2, "Vaccum"); // array slot 1
            todoArray.AddTodoToArray(3, "Wash"); // array slot 2
            todoArray.AddTodoToArray(4, "Dance"); // array slot 3
            Console.WriteLine(todoArray.Size());

            Person pers = new Person("Albin", "de Val");
            Person pers2 = new Person("Håkan", "Hellström");
            Person pers3 = new Person("Martin", "Martinsson");

            //todoArray.FindById(1).Done = true;  //Setting one todo to True, other 2 should be false (as per their starting value)

            todoArray.FindById(1).Assignee = pers; // asigning our 3 persons to our 3 todo taks
            todoArray.FindById(2).Assignee = pers2;
            todoArray.FindById(3).Assignee = pers3;

            //assert 
            //Console.WriteLine(todoArray.FindByDoneStatus(true));
            Console.WriteLine(todoArray.FindByAssignee(pers)[0].Assignee.FirstName);
            Console.WriteLine(todoArray.FindByAssignee(pers2)[0].Assignee.FirstName);
            Console.WriteLine(todoArray.FindByAssignee(pers3)[0].Assignee.FirstName);
            Console.WriteLine(todoArray.FindByAssignee(1)[0].Assignee.FirstName);

            //Console.WriteLine(todoArray.FindUnassignedTodoItems()[0].Description);

            */
        }
    }
}
