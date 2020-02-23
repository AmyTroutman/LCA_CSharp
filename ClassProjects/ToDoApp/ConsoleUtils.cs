using System;
namespace ToDoApp
{
    public class ConsoleUtils
    {
        public string MenuSelect;
        public string NewTask;
        int MarkDone;
        int DeleteTask;

        public ConsoleUtils(string menuSelect, string newTask, int markDone, int deleteTask)
        {
            this.MenuSelect = menuSelect;
            this.NewTask = newTask;
            this.MarkDone = markDone;
            this.DeleteTask = deleteTask;
        }

        public void Menu(string menuSelect)
        {
            Console.WriteLine(
            "List-0-Matic",        
            "What would like to do?",
            "NEW: add a new task to your todo list.",
            "DONE: mark a task as done.",
            "DELETE: remove a task from your list.",
            "ALL: Print all tasks.",
            "ACTIVE: Print active tasks.",
            "INACTIVE: Print completed tasks.",
            "QUIT: Paranoid save and exit the program."
            );
            menuSelect = Console.ReadLine().ToUpper();
        }

        public void New(string newTask)
        {
            Console.WriteLine("Tell me what you need to do:");
            newTask = Console.ReadLine();
        }

        //todo: convert strings to ints
        public void Done(int markDone)
        {
            PrintActive();
            Console.WriteLine("Enter the ID of the task you want to mark as done:");
            //put in the convert to int thing
            //int markDone = Console.ReadLine();
        }

        public void Delete(int deleteTask)
        {
            PrintAll();
            Console.WriteLine("Enter the ID of the task you would like to delete: ");
            //put in the convert to int thing
            //int deleteTask = Console.ReadLine();
        }

        //todo: build print methods
        public void PrintAll()
        {
            //Prints all tasks
        }

        public void PrintActive()
        {
            //Prints all active tasks
        }

        public void PrintInactive()
        {
            //Prints all inactive tasks
        }

        public void BadRequest()
        {
            Console.WriteLine("I don't recognize that command. Try one of the UPPERCASE commands.");
        }

        public void QuitPrint()
        {
            Console.WriteLine("Here are you active tasks: ");
        }
    }
}


//handle printing to the console, and reading from the console.
//We want to contain all code that handles user input and display to the
//ConsoleUtils class. Should not directly interact with the ItemRepository
//class or edit the database. (This is the only class that should have
//Console.WriteLine() and Console.ReadLine().)