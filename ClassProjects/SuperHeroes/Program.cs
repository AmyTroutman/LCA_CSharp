using System;
using System.Collections.Generic;

namespace SuperHeroes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person("Robert", "Bob");
            Hero h1 = new Hero("Fireman", "John", "Fireball", null);
            Villain v1 = new Villain("Fireman", "AquaMan", null);
            List<Person> people = new List<Person>
            {
                p1,
                h1,
                v1
            };

            foreach (Person character in people)
            {
                character.PrintGreeting();
            }
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
        
        public override String ToString() { return String.Format("{0}: ", Name); }

        public virtual void PrintGreeting()
        {
            Console.WriteLine(ToString() + "Hello, my name is {0} but you can call me {1}.", Name, NickName);
        }
    }

    public class Hero : Person
    {
        public string RealName { get; set; }
        public string SuperPower { get; set; }

        public Hero(string name, string realName, string superPower, string nickName) : base (name, nickName)
        {
            this.Name = name;
            this.RealName = realName;
            this.SuperPower = superPower;
            this.NickName = null;
        }

        public override void PrintGreeting()
        {
            Console.WriteLine(ToString() + "I am {0}. When I am {1}, my super power is {2}!", RealName, Name, SuperPower);
        }

    }

    public class Villain :  Person
    {
        string Nemesis { get; set; }

        public Villain(string nemesis, string name, string nickName) : base (name, nickName)
        {
            this.Nemesis = nemesis;
            this.Name = name;
            this.NickName = null;
        }

        public override void PrintGreeting()
        {
            Console.WriteLine(ToString() + "I am {0}. Have you seen {1}?!!",
            Name, Nemesis);
        }
    }
}
