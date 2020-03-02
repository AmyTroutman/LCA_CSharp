using System;
using System.Collections.Generic;

namespace ToDoApp
{
    public class ConsoleUtils
    {
              
        public ConsoleUtils()
        {
        }

        /// <summary>
        /// Main menu printer.
        /// </summary>
        public static void Menu()
        {
            Console.WriteLine("~~List-0-Matic~~");
            Console.WriteLine("What would like to do?");
            Console.WriteLine("ADD: add a new task to your todo list.");
            Console.WriteLine("DONE: mark a task as done.");
            Console.WriteLine("DELETE: remove a task from your list.");
            Console.WriteLine("PRINT: Prints your ToDo list.");
            Console.WriteLine("QUIT: Paranoid save and exit the program.");                     
        }

        #region User Prompts
        
        /// <summary>
        /// Takes main menu user input and checks that it is valid.
        /// </summary>
        /// <returns>
        /// Returns input to the App switch, whichs calls the various methods
        /// </returns>        
        public static string GetInput()
        {            
            string userInput = Console.ReadLine().ToUpper().Trim();
            string input = "";
            bool run;

            do
            {               
                switch (userInput)  
                {
                    case "ADD":                  
                        input = "addItem";
                        run = false;
                        break;
                    case "DELETE":
                        input = "deleteItem";
                        run = false;
                        break;
                    case "DONE":
                        input = "markDone";
                        run = false;
                        break;
                    case "PRINT":
                        input = "printList";
                        run = false;
                        break;                    
                    case "QUIT":
                        input = "quit";
                        run = false;
                        break;
                    default: //error display message
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Invaid Option!");
                        run = false;                        
                        break;
                }
            } while (run == true);
            return input;
        }

        /// <summary>
        /// Asks for a task.
        /// </summary>
        /// <returns>
        /// Returns new task to ItemRepo's AddTask method
        /// </returns>
        /// todo: don't allow empty strings
        public static string AddPrompt()
        {
            string task = null;
            bool validInput = false;
            do
            {
                Console.WriteLine("Tell me what you need to do:");
                string input = Console.ReadLine().Trim();
                if(input == "")
                {
                    Console.WriteLine("You can't do nothing...");
                }
                else
                {
                    task = input;
                    validInput = true;
                }

            } while (validInput == false);
            return task;
        }

        /// <summary>
        /// Asks for the ID of the task to be modified
        /// </summary>
        /// <returns>
        /// Returns ID to ItemRepo's DoneTask and DeleteTask methods
        /// </returns>
        public static int IDPrompt()
        {            
            Console.WriteLine("Enter the ID of the task you want to modify:");
            string idStr = Console.ReadLine();            
            Int32.TryParse(idStr, out int idTask);
            return idTask;
        }

        /// <summary>
        /// Called after choosing PRINT from main menu.
        /// </summary>
        /// <returns>
        /// Returns printType to ItemRepo's GetList
        /// </returns>
        public static string PrintPrompt()
        {
            
            Console.WriteLine("What tasks would you like to see: ALL, PENDING, DONE?");
            string printType = Console.ReadLine().ToUpper().Trim();
            return printType;            
        }      
        #endregion

        #region List Printer

        /// <summary>
        /// A print stencil
        /// </summary>
        /// <param name="ToDoList"></param>
        /// <returns></returns>
        public List<ToDoItem> PrintList(List<ToDoItem> ToDoList)
        {
            Console.Clear();
            
            Console.WriteLine();
            foreach(var i in ToDoList)
            {
                Console.WriteLine($"{i.ID} | {i.Description} | {i.Status}");
            }
            Console.WriteLine();
            return ToDoList;
        }     
        #endregion

        #region Replies

        /// <summary>
        /// Prints with no input/output. Mostly to acknowledge a process happened.
        /// </summary>
        public static void DoneReply()
        {
            Console.Clear();
            Console.WriteLine("Action successful.");
            Console.WriteLine();
        }

        public static void FailReply()
        {
            Console.Clear();
            Console.WriteLine("Action failed.");
            Console.WriteLine();
        }

        public static void QuitPrint()
        {
            Console.WriteLine();
            Console.WriteLine("ToDo list saved.");
            Console.WriteLine("See you later!");
            Console.ReadKey();
        }
        #endregion
    }
}

//CLASS RESPONSIBLITIES
//handle printing to the console, and reading from the console.
//We want to contain all code that handles user input and display to the
//ConsoleUtils class. Should not directly interact with the ItemRepository
//class or edit the database. (This is the only class that should have
//Console.WriteLine() and Console.ReadLine().