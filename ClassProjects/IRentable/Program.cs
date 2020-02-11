using System;
using System.Collections.Generic;
namespace Rentable
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<IRentable> rentals = new List<IRentable>
            {
                new Car("Mitsubishi Mirage", "-you can't get any slower than this one-", 32, 85),
                new Car("Your Mom's Suburban", "fits you and your kids and your stuff and the dog,", 15, 100),
                new Boat("TooFastTooFurious 3000", "**speed boat**", "quick getaway ;)", 200),
                new Boat("Unsinkable 2", "boat, obviously", "fishing trip with your dad", 100),
                new House("Manchester Glory", 5, 4, 18, 900),
                new House("Old Man Johnson's", 2, 1, 5, 100),
            };

            foreach (IRentable rental in rentals)
            {
                Console.WriteLine(rental.GetType());
                rental.GetDescription();
                rental.GetDailyRate();
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
public interface IRentable
{
    void GetDailyRate();
    void GetDescription();
}

public class Boat : IRentable
{
    string Name;
    string BoatType;
    string Quip;
    int Rate;
    public Boat(string name, string boatType, string quip, int rate)
    {
        this.Name = name;
        this.BoatType = boatType;
        this.Quip = quip;
        this.Rate = rate;
    }
    public void GetDailyRate()
    {
        Console.WriteLine("The {0} rents at a rate of ${1} an hour.", Name, Rate);
    }
    public void GetDescription()
    {
        Console.WriteLine("The {0} is a {1}, perfect for a {2}!", Name, BoatType, Quip);
    }
}
public class Car : IRentable
{
    string Name;
    string Quip;
    int MPG;
    int Rate;
    public Car(string name, string quip, int mpg, int rate)
    {
        this.Name = name;
        this.Quip = quip;
        this.MPG = mpg;
        this.Rate = rate;
    }
    public void GetDailyRate()
    {
        Console.WriteLine("The {0} rents at a rate of ${1} a day.", Name, Rate);
    }
    public void GetDescription()
    {
        Console.WriteLine("{0} {1} with an amazing {2} MPG!", Name, Quip, MPG);
    }
}
public class House : IRentable
{
    string Name;
    int Bed;
    int Bath;
    int Guest;
    int Rate;
    public House(string name, int bed, int bath, int guest, int rate)
    {
        this.Name = name;
        this.Bed = bed;
        this.Bath = bath;
        this.Guest = guest;
        this.Rate = rate;
    }
    public void GetDailyRate()
    {
        Console.WriteLine("The {0} rents at a rate of ${1} a week.", Name, Rate);
    }
    public void GetDescription()
    {
        Console.WriteLine("Welcome to the {0}, a {1} bedroom, {2} bathroom home that comfortably sleeps {3} guests!", Name, Bed, Bath, Guest);
    }
}
