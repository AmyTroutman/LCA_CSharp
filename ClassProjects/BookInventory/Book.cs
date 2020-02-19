using System;
namespace BookInventory
{
    class Book : BookContext
    {
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Author { get; set; }
        
        public Book(string title, string author)
        {
            this.Title = title;
            this.Author = author;
        }
    }
}
