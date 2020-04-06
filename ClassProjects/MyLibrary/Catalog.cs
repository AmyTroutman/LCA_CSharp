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

        public List<Book> GetList(string printType)
        {
            List<Book> FilterList = new List<Book>().ToList();
            if (printType == "all")
            {
                FilterList = context.Library.ToList();
            }
            else if (printType == "author")
            {
                FilterList = context.Library.Where(x => x.Author == /*todo*/).ToList();
            }
            else if (printType == "genre")
            {
                FilterList = context.Library.Where(x => x.Genre == /*todo*/).ToList();
            }
            return FilterList;
        }
    }
}
