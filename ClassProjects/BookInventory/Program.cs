using System;

namespace BookInventory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool stop = false;
            BookContext context = new BookContext();
            context.Database.EnsureCreated();
            do
            {
                Console.WriteLine("What is the name of the book you'd like to add to the library?");
                string title = Console.ReadLine();
                Console.WriteLine("Who is the author of {0}?", title);
                string author = Console.ReadLine();
                Book newBook = new Book(title, author);
                context.MyLibrary.Add(newBook);
                context.SaveChanges();
                Console.WriteLine("{0} was added to your library! Would you like to add another book?", title);
                string answer = Console.ReadLine().ToLower();
                if (answer == "no")
                {
                    stop = true;
                }
            } while (stop == false);
            Console.WriteLine("These are the books in your library:");

            foreach (Book b in context.MyLibrary)
            {
                Console.WriteLine("{0}: {1} by {2}", b.Id, b.Title, b.Author);
            }
        }
    }
}
