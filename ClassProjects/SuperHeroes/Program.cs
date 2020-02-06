using System;

namespace SuperHeroes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
    }
}
