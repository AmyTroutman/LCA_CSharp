using System;

namespace ClassCollections
{  
    class MainClass
    {
        public static void Main(string[] args)
        {
            License myLicense = new License("Amy", "Troutman", "female", 6);
            //oy, why can't you acces these???
            License.MakeFullName(initialFirst, initialLast);
            Console.WriteLine(myLicense.FullName);
        }
       
    }
    class License
    {
        //first name
        public string FirstName { get; set; }
        //last name
        public string LastName { get; set; }
        //full name
        public string FullName { get; private set; }
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
        public void MakeFullName(string initialFirst, string initialLast)
        {
            FullName = initialFirst + " " + initialLast;
        }

    }


    class Book
    {
        //title
        public string Title { get; set; }
        //authors (allow for multiple)        
        public string[] Author { get; set; }
        public int Size { get; set; }        
        //int pages
        public int Pages { get; set; }
        //SKU
        public string Sku { get; set; }
        //publisher
        public string Publisher { get; set; }
        //int price
        public int Price { get; set; }
        //constructor
        
        public Book(int initialSize, string[] Author)
        {
            Size = initialSize;
            this.Author = new string[initialSize];
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
        //constructor
        public Airplane()
        {

        }
    }
}
