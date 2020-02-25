﻿using System;
namespace ToDoApp
{
    public class ConsoleUtils
    {
              
        public ConsoleUtils()
        {
        }
       
        public static void Menu()
        {
            Console.WriteLine(
            "List-0-Matic",                    
            "NEW: add a new task to your todo list.",
            "DONE: mark a task as done.",
            "DELETE: remove a task from your list.",            
            "ACTIVE: Print active tasks.",
            "INACTIVE: Print completed tasks.",
            "ALL: Print all tasks.",
            "QUIT: Paranoid save and exit the program."
            );          
        }

        public static string NewPrompt()
        {
            Console.WriteLine("Tell me what you need to do:");
            string task = Console.ReadLine();
            return task;
        }
       
        public static int DonePrompt()
        {
            PrintActive();
            Console.WriteLine("Enter the ID of the task you want to mark as done:");
            string idStr = Console.ReadLine();
            int idDone = Convert.ToInt32(idStr);
            return idDone;
        }

        public static int DeletePrompt()
        {
            PrintAll();
            Console.WriteLine("Enter the ID of the task you would like to delete: ");
            string idStr = Console.ReadLine();
            int idDel = Convert.ToInt32(idStr);
            return idDel;
        }

        //todo: build print methods
        public static void PrintAll()
        {
            foreach (ToDoItem t in context.ToDoList)
            {
                Console.WriteLine("{0}: {1} by {2}", t.ID, t.Description, t.Status);
            }
        }

        public static void PrintActive()
        {
            //Prints all active tasks
            //linq where status == pending
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
        
        public static string GetInput()
        {            
            Console.WriteLine("/nWhat would like to do?"); 
            string userInput = Console.ReadLine().ToUpper().Trim();
            string input = "";
            bool validInput = false;

            do
            {
                switch (userInput) // find user selection 
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
    }
}


//handle printing to the console, and reading from the console.
//We want to contain all code that handles user input and display to the
//ConsoleUtils class. Should not directly interact with the ItemRepository
//class or edit the database. (This is the only class that should have
//Console.WriteLine() and Console.ReadLine().)