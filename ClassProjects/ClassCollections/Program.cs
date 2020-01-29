using System;

namespace ClassCollections
{  
    class MainClass
    {
        public static void Main()
        {
            License myLicense = new License("Amy", "Troutman", "female", 74324506);            
            Console.WriteLine(myLicense.MakeFullName());
            Console.WriteLine("DL Number: " +myLicense.DLNumber);

            Book myBook = new Book("Too Much", "Sufjan Stevens", 135);            
            Console.WriteLine(myBook.AboutBook());

            Airplane myPlane = new Airplane("Boeing", "SuperBird", 7);
            Console.WriteLine(myPlane.AboutPlane());
        }
       
    }
    class License
    {
        //first name
        public string FirstName { get; set; }
        //last name
        public string LastName { get; set; }
        //full name
        public string FullName { get; set; }
        //gender
        public string Gender { get; set; }
        //int license number
        public int DLNumber { get; set; }
        //constructor. needs to have gender and number too
        public License(string initialFirst, string initialLast, string initialGender, int initialDLN)
        {
            FirstName = initialFirst;
            LastName = initialLast;
            Gender = initialGender;
            DLNumber = initialDLN;
        }
        //now a method that concatenates names        
        public string MakeFullName()
        {
            return FullName= FirstName +" "+ LastName;
        }        
    }


    class Book
    {
        //title
        public string Title { get; set; }
        //authors (allow for multiple)        
        public string Author { get; set; }       
        //int pages
        public int Pages { get; set; }
        //SKU
        public string Sku { get; set; }
        //publisher
        public string Publisher { get; set; }
        //int price
        public int Price { get; set; }
        public string BookBlurb { get; set; }

        //constructor
        public Book(string initialTitle, string initialAuthor, int initialPages)
        {
            Title = initialTitle;
            Author = initialAuthor;
            Pages = initialPages;
        }
       
        public string AboutBook()
        {
            return BookBlurb = Title + " by " + Author + " has " + Pages + " pages.";
        }
        
    }

    class Airplane
    {
        //manufacturer
        public string Manufacturer { get; set; }
        //model
        public string Model { get; set; }
        //variant
        public string Variant { get; set; }
        //int capacity
        public int Capacity { get; set; }
        //int engines
        public int Engines { get; set; }
        public string PlaneBlurb { get; set; }
        //constructor
        public Airplane(string initialManu, string initialMod, int initialCap)
        {
            Manufacturer = initialManu;
            Model = initialMod;
            Capacity = initialCap;
        }
        public string AboutPlane()
        {
            return PlaneBlurb = "The " + Manufacturer + " " + Model + " can hold " + Capacity + " passengers.";
        }
    }
}
