using System;
using System.Collections.Generic;
using System.Linq;
using static MyLibrary.MouthEars;

namespace MyLibrary
{
    public class Catalog
    {
        public static BookContext context = new BookContext();
        public bool success = false;
        public Catalog()
        {
            context.Database.EnsureCreated();
        }
        public static void NewBook()
        {
            Book newBook = new Book(TitlePrompt(), AuthorPrompt(), GenrePrompt());
            context.Library.Add(newBook);
            context.SaveChanges();
        }
    }
}
