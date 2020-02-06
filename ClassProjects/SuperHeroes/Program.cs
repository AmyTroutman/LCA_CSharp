using System;
using System.Collections.Generic;

namespace SuperHeroes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person("Robert", "Bob");
            Hero h1 = new Hero("Fireman", null, "John", "Fireball");
            Villain v1 = new Villain("Fireman", "AquaMan", null);
            List<Person> mereMortals = new List<Person>();
            List<Hero> goodGuys = new List<Hero>();
            List<Villain> badDudes = new List<Villain>();
            mereMortals.Add(p1);
            goodGuys.Add(h1);
            badDudes.Add(v1);
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string NickName { get; set; }
        public Person(string name, string nickName)
        {
            this.Name = name;
            this.NickName = nickName;
        }
        //Why do I do this? Somewhere I'm supposed to ToString...
        public override String ToString() { return String.Format("{0}", Name); }
        public void PrintGreeting()
        {
            Console.WriteLine("Hello, my name is {0} but you can call me {1}.", Name, NickName);
        }
    }
    public class Hero : Person
    {
        public string RealName { get; set; }
        public string SuperPower { get; set; }
        public Hero(string name, string nickName, string realName, string superPower) : base (name, nickName)
        {
            this.Name = name;
            this.RealName = realName;
            this.SuperPower = superPower;
            NickName = null;
        }
        public new void PrintGreeting()
        {
            Console.WriteLine("I am {0}. When I am {1}, my super power is { 2 }!", RealName, Name, SuperPower);
        }

    }
    public class Villain :  Person
    {
        string Nemesis { get; set; }
        public Villain(string nemesis, string name, string nickName) : base (name, nickName)
        {
            this.Name = name;
            this.NickName = null;
            this.Nemesis = nemesis;
        }
        public new void PrintGreeting()
        {
            Console.WriteLine("I am {0}. Have you seen {1}?!!",
            Nemesis, Name);
        }
    }
}
