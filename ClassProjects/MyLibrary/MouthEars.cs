using System;
using System.Collections.Generic;

namespace MyLibrary
{
    public class MouthEars
    {
        public MouthEars()
        {
        }

        #region menu and menu input
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. ADD a new book.");
            Console.WriteLine("2. DELETE a book.");
            Console.WriteLine("3. UPDATE a book.");
            Console.WriteLine("4. SORT library.");
            Console.WriteLine("5. QUIT");
        }

        public static string MenuInput()
        {
            string userInput = Console.ReadLine().ToUpper().Trim();
            string input = "";
            bool run;

            do
            {
                switch (userInput)
                {
                    case "ADD":
                    case "1":
                        input = "addBook";
                        run = false;
                        break;
                    case "DELETE":
                    case "2":
                        input = "deleteBook";
                        run = false;
                        break;
                    case "UPDATE":
                    case "3":
                        input = "updateBook";
                        run = false;
                        break;
                    case "SORT":
                    case "4":
                        input = "sortLibrary";
                        run = false;
                        break;
                    case "QUIT":
                    case "5":
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
        #endregion

        #region Prompts
        
        /// <summary>
        /// Book builder prompts
        /// </summary>
        /// <returns>newBook parameters: title, author, genre</returns>
        public static string TitlePrompt()
        {
            string title = null;
            bool validInput = false;
            do
            {                
                Console.WriteLine("What is the title of the book?");
                string input = Console.ReadLine().Trim();
                if(input == "")
                {
                    Console.WriteLine("You cannot leave title blank.");
                }
                else
                {
                    title = input;
                    validInput = true;
                }
                
            } while (validInput == false);
            return title;
        }
        public static string AuthorPrompt()
        {
            string author = null;
            bool validInput = false;
            do
            {
                Console.WriteLine("Who is the author of the {0}", TitlePrompt());
                string input = Console.ReadLine().Trim();
                if (input == "")
                {
                    Console.WriteLine("You cannot leave author blank.");
                }
                else
                {
                    author = input;
                    validInput = true;
                }   
            } while (validInput == false);
            return author;
        }
        public static string GenrePrompt()
        {
            string genre = null;
            bool validInput = false;
            do
            {
                Console.WriteLine("What is the genre of {0}", TitlePrompt());
                string input = Console.ReadLine().Trim();
                if(input == "")
                {
                    Console.WriteLine("You cannot leave genre blank.");
                }
                else
                {
                    genre = input;
                    validInput = true;
                }
            } while (validInput == false);
            return genre;
        }

        public static int DeletePrompt()
        {
            Console.WriteLine("Enter the Id of the book you would like to remove from the library:");
            string input = Console.ReadLine().Trim();
            Int32.TryParse(input, out int idBook);
            return idBook;
        }
        #endregion

        #region TalkBacks
        public static string BadPrint()
        {
            return "I don't recognize that input.";
        }
        public static string QuitPrint()
        {
            return "Thanks for updating the library!";
        }
        #endregion
    }
}