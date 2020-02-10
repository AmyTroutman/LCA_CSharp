using System;
using System.Collections.Generic;

namespace CarLot
{
    class Program
    {
        public static void Main(string[] args)
        {
            //make two CarLots
            CarLot cl1 = new CarLot("Pretty Good Cars", new List<Vehicle>());
            CarLot cl2 = new CarLot("Bob's O-K Car-ral", new List<Vehicle>());

            //make some cars
            Car car01 = new Car("ART1985", "Mazda", "Mazda3", 22000, "hatchback", 5);
            Car car02 = new Car("DEF5678", "Honda", "Fit", 32000, "hatchback", 5);
            Car car03 = new Car("JFK1234", "Nissan", "Sentra", 12000, "sedan", 4);
            Car car04 = new Car("RMT1086", "Toyota", "Corolla", 32000, "sedan", 4);
            Truck truck01 = new Truck("GHI9012", "Toyota", "Tacoma", 54000, "XXL", "20 gross tons");
            Truck truck02 = new Truck("TRU3452", "Ford", "F150", 65000, "X-Tendo-Matic", "5 tonnes");
            Truck truck03 = new Truck("EFT2932", "Mazda", "Mazda", 4000, "Regular", "1 Metric Ton");
           

            //add to lists            
            cl1.ToList(car01);
            cl1.ToList(truck02);
            cl1.ToList(car03);
            cl2.ToList(truck01);
            cl2.ToList(car02);
            cl2.ToList(car04);
            cl2.ToList(truck03);

            //print inventories
            cl1.PrintInv();
            cl2.PrintInv();
        }
    }

    class CarLot
    {
        string LotName { get; set; }
        public List<Vehicle> Vehicles = new List<Vehicle>();

        public CarLot (string lotName, List<Vehicle> vehicles)
        {
            this.LotName = lotName;
            this.Vehicles = vehicles;
        }

        //method to add cars (objects) to lots (lists)
        public void ToList(Vehicle vehicle)
        {
                Vehicles.Add(vehicle);
        }

        //method for printing inventory
        public void PrintInv()
        {
            //get number of cars in inv
            int InvCount = Vehicles.Count;

            //print lot info
            //remembered to do the ${ } thing!
            Console.WriteLine($"{LotName} - Inventory:\n");
            Console.WriteLine($"Number of vehicles in inventory:\n {InvCount}");

            //print info on each car in lot
            foreach (var item in Vehicles)
            {
                Console.WriteLine(item.Info());
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
        //japes
        public virtual string Info()
        {
            return "If you can see this, something went wrong...";
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

        public override string Info()
        {
            return  
                $"\nLicense Plate Number: {Plate}" +
                $"\nMake: {Make}" +
                $"\nModel: {Model}" +
                $"\nPrice: ${Price}" +
                $"\nType: {Type}" +
                $"\nNumber Of Doors: {Doors}\n";
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

        public override string Info()
        {
            return 
                $"\nLicense Plate Number: {Plate}" +
                $"\nMake: {Make}" +
                $"\nModel: {Model}" +
                $"\nPrice: ${Price}" +
                $"\nType: {BedSize}" +
                $"\nHauling Capacity: {HaulingCap}\n";
        }
    }

}
