using System;
namespace ToDoApp
{
    public class ConsoleUtils
    {
        public ConsoleUtils()
        {
        }
    }
}


//handle printing to the console, and reading from the console.
//We want to contain all code that handles user input and display to the
//ConsoleUtils class. Should not directly interact with the ItemRepository
//class or edit the database. (This is the only class that should have
//Console.WriteLine() and Console.ReadLine().)