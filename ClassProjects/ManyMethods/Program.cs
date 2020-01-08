using System;

namespace ManyMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            hello();
            Addition();
            catDog();
            oddEvent();
            inches();
            echo();
            killGrams();
            date();
            age();
            guess();


                Console.ReadKey();
        }

        static void hello()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("You entered " + name);
        }

        static void Addition()
        {
            int firstNumber = 3;
            int secondNumber = 5;
            Console.WriteLine(firstNumber + secondNumber);
        }

        static void catDog()
        {
            Console.WriteLine("Do you like cats or dogs?");
            string answer = Console.ReadLine();
            if (answer == "cats")
            {
                Console.WriteLine("meow");
            }
            else
            {
                Console.WriteLine("woof");
            }
        }

        static void oddEvent()
        {
            Console.WriteLine("Give me a number and I'll tell you if it's odd or even!");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("It's even!");
            }
            else
            {
                Console.WriteLine("It's odd!");
            }
        }

        static void inches()
        {
            Console.WriteLine("Give me your height in feet and I'll convert it to inches.");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(height * 12);
        }

        static void echo()
        {
            Console.WriteLine("What's your favorite thing?!");
            string fav = Console.ReadLine();
            Console.WriteLine(fav.ToUpper());
            Console.WriteLine(fav.ToLower());
            Console.WriteLine(fav.ToLower());
        }

        static void killGrams()
        {
            Console.WriteLine("Give me a weight in pounds and I'll convert it to kilograms!");
            int pounds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pounds / 2.2046);
        }

        static void date()
        {
            Console.WriteLine(DateTime.Today.ToString("MM-dd-yyyy"));
        }

        static void age()
        {
            Console.WriteLine("What year were you born?");
            int year = Convert.ToInt32(Console.ReadLine());
            int thisYear = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            float yourAge = (thisYear - year);
            Console.WriteLine("You are " + yourAge + " years old!");
        }

        static void guess()
        {
            Console.WriteLine("Guess the secret word!");
            string word = Console.ReadLine();
            if (word == "csharp")
            {
                Console.WriteLine("CORRECT!!!");
            }
            else
            {
                Console.WriteLine("WRONG!!");
            }
            
        }
    }
}
