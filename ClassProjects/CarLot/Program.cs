using System;
using System.Collections.Generic;

//my enums, they should be for like make, model, type, hauling?
//an enum for each field.
//public enum Make { Mazda, Toyota, Ford, Honda }
//public enum Model { Mazda3, Mazda5, Corolla, Tacoma, F150, Taurus, Civic, Fit }
//public enum Type { Sedan, Coupe, Hatchback }
//public enum HaulingCap { Ton, MegaTon, Tonne, GrossTon }

namespace CarLot
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //make two CarLots
            CarLot cl1 = new CarLot("Pretty Good Cars", new List<Vehicle>());
            CarLot cl2 = new CarLot("Bob's O-K Car-ral", new List<Vehicle>());

            //make some cars
            Car car01 = new Car("ABC1234", "Mazda", "Mazda3", 22000, "hatchback", 5);
            Car car02 = new Car("DEF5678", "Honda", "Fit", 32000, "hatchback", 5);
            Truck truck01 = new Truck("GHI9012", "Toyota", "Tacoma", 54000, "XXl", "20 gross tons");
            Truck truck02 = new Truck("TRU3452", "Ford", "F150", 65000, "X-Tendo-Matic", "5 tonnes");

            //add to list            
            cl1.ToList(car01);
            cl1.ToList(truck02);
            cl2.ToList(truck01);
            cl2.ToList(car02);

            //print inventory
            PrintInv();
        }
    }

    class CarLot
    {
        string LotName { get; set; }
        List<Vehicle> Vehicles = new List<Vehicle>();

        public CarLot (string lotName, List<Vehicle> vehicles)
        {
            this.LotName = lotName;
            this.Vehicles = vehicles;
        }

        //the list add thingy
        public void ToList(Vehicle vehicle)
        {
                Vehicles.Add(vehicle);
        }
        public void PrintInv()
        {
            //mebbe like this??
            foreach (object car in Vehicles)
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
        

        public Vehicle(string plate, string make, string model, int price)
        {
            this.Plate = plate;
            this.Make = make;
            this.Model = model;
            this.Price = price;
            
        }
    }

    class Car : Vehicle
    {
        public string Type { get; set; }
        public int Doors { get; set; }        

        public Car(string plate, string make, string model, int price, string type, int doors) : base(plate, make, model, price)
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

        public Truck(string plate, string make, string model, int price, string bedSize, string haulingCap) : base(plate, make, model, price)
        {
            this.Plate = plate;
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.BedSize = bedSize;
            this.HaulingCap = haulingCap;
            
        }
    }

}
