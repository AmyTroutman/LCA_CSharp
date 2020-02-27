using System;
namespace ToDoApp
{
    public class ConsoleUtils
    {
              
        public ConsoleUtils()
        {
        }

       //prints main menu
        public static void Menu()
        {
            Console.WriteLine(
            "List-0-Matic /nNEW: add a new task to your todo list./n /nDONE: mark a task as done./n /nDELETE: remove a task from your list./n /nACTIVE: Print active tasks./n /nINACTIVE: Print completed tasks./n /nALL: Print all tasks./n /nQUIT: Paranoid save and exit the program./n"
            );          
        }

        #region User Prompts

        /// <summary>
        /// Takes main menu user input and checks that it is valid.
        /// </summary>
        /// <returns>Returns input to App switch, whichs calls the various methods</returns>
        public static string GetInput()
        {
            Console.WriteLine("What would like to do?");
            string userInput = Console.ReadLine().ToUpper().Trim();
            string input = "";
            bool validInput = false;

            do
            {
                switch (userInput)  
                {
                    case "NEW":
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
                    case "All":
                        input = "printAll";
                        validInput = true;
                        break;
                    case "ACTIVE":
                        input = "printActive";
                        validInput = true;
                        break;
                    case "INACTIVE":
                        input = "printInactive";
                        validInput = true;
                        break;
                    case "QUIT":
                        input = "quit";
                        validInput = true;
                        break;
                    default: //error display message                    
                        Console.WriteLine("\nInvaid Option!");
                        break;
                }
            } while (validInput == false);
            return input;
        }

        /// <summary>
        /// Asks for a task.
        /// </summary>
        /// <returns>Returns new task to ItemRepo's AddTask method</returns>
        public static string NewPrompt()
        {
            Console.WriteLine("Tell me what you need to do:");
            //todo: check for null input
            string task = Console.ReadLine();
            if (task != null)
            {
                return task;
            }
            return "Invalid input";
        }

        /// <summary>
        /// Asks for the ID of the task to be marked completed
        /// </summary>
        /// <returns>Returns ID to ItemRepo's DoneTask method</returns>
        public static int DonePrompt()
        {
            PrintActive();
            Console.WriteLine("Enter the ID of the task you want to mark as done:");
            string idStr = Console.ReadLine();
            //done: switch to tryparse for error handling
            //int idDone = Convert.ToInt32(idStr);
            Int32.TryParse(idStr, out int idDone);
            return idDone;
        }
        public static void DoneReply() {
            Console.WriteLine("Status updated.");            
        }


        /// <summary>
        /// Asks for the ID of the task to be deleted.
        /// </summary>
        /// <returns>Returns ID to ItemRepo's DeleteTask method.</returns>
        public static int DeletePrompt()
        {
            PrintAll();
            Console.WriteLine("Enter the ID of the task you would like to delete: ");
            string idStr = Console.ReadLine();
            //done: switch to tryparse for error handling
            //int idDel = Convert.ToInt32(idStr);
            Int32.TryParse(idStr, out int idDel);
            return idDel;
        }
        #endregion

        #region Print methods
        //todo: build print methods
        //how do I access context if ConsoleUtils isn't allowed to access ItemRepo?
        public static void PrintAll()
        {
            //foreach (ToDoItem t in context.ToDoList)
            //{
            //    Console.WriteLine("{0}: {1} by {2}", t.ID, t.Description, t.Status);
            //}
        }

        public static void PrintActive()
        {
            //Prints all active tasks
            //linq where status == pending
            //foreach(var item in ItemRepository.GetList("pending"))
            //{
            //    Console.WriteLine(item);
            //}
        }

        public static void PrintInactive()
        {
            //Prints all inactive tasks
            //linq where status == done
        }

        public static void QuitPrint()
        {
            Console.WriteLine("ToDo list saved.");
            Console.WriteLine("Here are you active tasks: ");
            PrintActive();
            Console.WriteLine("Get to work!");
        }
        #endregion

        
    }
}


//handle printing to the console, and reading from the console.
//We want to contain all code that handles user input and display to the
//ConsoleUtils class. Should not directly interact with the ItemRepository
//class or edit the database. (This is the only class that should have
//Console.WriteLine() and Console.ReadLine().)