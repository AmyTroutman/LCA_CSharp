using System;
using System.Linq;

namespace BookInventory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool stop = false;         
            BookContext context = new BookContext();
            context.Database.EnsureCreated();

            Console.WriteLine("Welcome to your personal library!");
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("What book would you like to add to the library?");
                string title = Console.ReadLine();
                Console.WriteLine("Who is the author of {0}?", title);
                string author = Console.ReadLine();

                Book newBook = new Book(title, author);
                context.MyLibrary.Add(newBook);
                context.SaveChanges();

                Console.WriteLine(" ");
                Console.WriteLine("{0} by {1} was added to your library!", title, author);
                Console.WriteLine("Would you like to add another book?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "no")
                {
                    stop = true;
                }
            } while (stop == false);

            Console.WriteLine(" ");           

            foreach (Book b in context.MyLibrary)
            {
                Console.WriteLine("{0}: {1} by {2}", b.Id, b.Title, b.Author);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Would you like to delete any books from your library?");
            string delete = Console.ReadLine().ToLower();

            if(delete == "yes")
            {
                stop = false;
                do
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("What is the ID the book you'd like to remove?");
                    string idStr = Console.ReadLine();
                    int idDel = Convert.ToInt32(idStr);

                    context.Remove(context.MyLibrary.Single(b => b.Id == idDel));                  
                    context.SaveChanges();

                    Console.WriteLine(" ");
                    Console.WriteLine("Updated library:");

                    foreach (Book b in context.MyLibrary)
                    {
                        Console.WriteLine("{0}: {1} by {2}", b.Id, b.Title, b.Author);
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("Would you like to delete another book?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "no")
                    {
                        stop = true;
                    }
                } while (stop == false);
            }

            Console.WriteLine(" ");
            int bookCount = context.MyLibrary.Count();
            Console.WriteLine("You have {0} books in your library.", bookCount);
            Console.WriteLine("These are the books in your library:");

            foreach (Book b in context.MyLibrary)
            {
                Console.WriteLine("{0}: {1} by {2}", b.Id, b.Title, b.Author);
            }
            
        }
    }
}
