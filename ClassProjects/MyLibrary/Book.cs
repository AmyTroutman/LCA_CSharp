using System;
namespace MyLibrary
{
    public class Book
    {
        //mandatory data
        public int ID { get; private set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        //optional data
        public string Series { get; set; }
        public int NumInSeries { get; set; }               
        public string Type { get; set; }
        public string LibraryLoc { get; set; }
        public string OffSyn { get; set; }
        public string MySyn { get; set; }

        public Book(string title, string author, string genre)
        {
            this.Title = title;
            this.Author = author;           
            this.Genre = genre;
        }
    }
}
