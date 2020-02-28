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
            bool validInput;

            do
            {
                switch (userInput)  
                {
                    case "ADD":
                        input = "addItem";
                        validInput = true;
                        break;
                    case "DELETE":
                        input = "deleteItem";
                        validInput = true;
                        break;
                    case "DONE":
                        input = "markDone";
                        validInput = true;
                        break;
                    case "PRINT":
                        input = "printList";
                        validInput = true;
                        break;                    
                    case "QUIT":
                        input = "quit";
                        validInput = true;
                        break;
                    default: //error display message                    
                        Console.WriteLine("Invaid Option!");
                        validInput = false;
                        break;
                }
            } while (validInput == false);
            return input;
        }

        /// <summary>
        /// Asks for a task.
        /// </summary>
        /// <returns>
        /// Returns new task to ItemRepo's AddTask method
        /// </returns>
        public static string AddPrompt()
        {
            Console.WriteLine("Tell me what you need to do:");        
            string task = Console.ReadLine();
            if (task == null)
            {
                return "Invalid input.";                
            }
            //todo: break this loop!
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
            //todo: make sure non-numerical input doesn't break the app
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
            if(printType == null)
            {                
                return "Invalid input.";
            }
            else
            {
                return printType;
                //todo: break this loop!
            }
        }      
        #endregion

        #region Print methods
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
            Console.WriteLine("Action successful.");
        }

        public static void FailReply()
        {
            Console.WriteLine("Action failed.");
        }

        public static void QuitPrint()
        {
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