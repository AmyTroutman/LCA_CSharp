using System;
using System.Collections.Generic;

//my enums, they should be for like make, model, jdpowers, type, hauling?
//an enum for each field.
public enum Make { Mazda, Toyota, Ford, Honda }
public enum Model { Mazda3, Mazda5, Corolla, Tacoma, F150, Taurus, Civic, Fit }
public enum JDPower { BestInClass, BestValue, BestPerformance }
public enum Type { Sedan, Coupe, Hatchback }
public enum HaulingCap { Ton, MegaTon, Tonne, GrossTon }

namespace CarLot
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //make two CarLots
            CarLot cl1 = new CarLot("Pretty Good Cars");
            CarLot cl2 = new CarLot("Bob's O-K Cars");

            //make some cars

            //add to list
            //Add();

            //print inventory
            //PrintInv();
        }
    }

    class CarLot
    {
        string LotName { get; set; }
        List<Vehicle> vehicles = new List<Vehicle>();

        public CarLot (string lotName)
        {
            this.LotName = lotName;
        }
        public void Add(Vehicle vehicle)
        {
            //the list add thingy
            vehicles.Add(vehicle);
        }
        public void PrintInv()
        {
            //mebbe like this??
            foreach (object car in vehicles)
            {
                Console.WriteLine(car);
            }
        }
    }

    abstract class Vehicle
    {
        public string Plate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string JDPowers { get; set; }

        public Vehicle(string plate, string make, string model, int price, string jdPowers)
        {
            this.Plate = plate;
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.JDPowers = jdPowers;
        }
    }

    class Car : Vehicle
    {
        public string Type { get; set; }
        public int Doors { get; set; }        

        public Car(string plate, string make, string model, int price, string jdPowers, string type, int doors) : base(plate, make, model, price, jdPowers)
        {
            this.Plate = plate;
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Type = type;
            this.Doors = doors;
        }
    }

    class Truck : Vehicle
    {
        public string BedSize { get; set; }
        public string HaulingCap { get; set; }

        public Truck(string plate, string make, string model, int price, string jdPowers, string bedSize, string haulingCap) : base(plate, make, model, price, jdPowers)
        {
            this.Plate = plate;
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.BedSize = bedSize;
            this.HaulingCap = haulingCap;
            this.JDPowers = jdPowers;
        }
    }

}
