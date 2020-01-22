using System;

namespace Mastermind
{


    class MainClass

    {
        public static string[] guess = new string [2];
        public static string[] password = new string [2];
        public static bool win;
        public static void Main()
        {
            Console.WriteLine("Let's play Mastermind! I've chosen two colors from a choice of green, blue, and orange. Guess the right colors in the right order and you win!");

            //Answer out here so it doesn't make a new password with every loop!
            Answer(password);
            do
            {
                Input(guess);
                
                Match(password, guess);
            } while (!Win(win));
            Console.ReadKey();

        }
        public static void Input(string[] guess)
        {
            //ask and get user guess
            Console.WriteLine("What is your guess?");
            string input = Console.ReadLine();
            //split guess into an array
            string[] splitInput = input.Split(' ');
            //permastoring that data, baby
            Array.Copy(splitInput, guess, 2);
            

        }
        public static void Answer(string[] password)
        {
            string[] Colors = { "green", "blue", "orange" };
            Random generator = new Random();
            // creates a number 0,1 or 2
            int randomNumber = generator.Next(0, 3);
            password[0] = Colors[randomNumber];
            password[1] = Colors[randomNumber];
            //test that password is getting a value
            foreach (string word in password)
            {
                Console.WriteLine("pword " + word);
            }
        }
        public static void Match(string[] password, string[] guess)
        {
            if (guess[0] == password[0])
            {
                //first and second colors
                if (guess[1] == password[1])
                {
                    Console.WriteLine("You guessed correctly!");
                    win = true;
                }
                //first matches, but second does not
                else
                {
                    Console.WriteLine("You have one color and it's position right!");
                }
            }
            //test that password is keeping value
            foreach (string word in password)
            {
                Console.WriteLine("pword " + word);
            }
            //test that guess data was stored
            foreach (string word in guess)
            {
                Console.WriteLine("gword " + word);
            }
        }
        public static bool Win(bool win)
        {
            if (win == true)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }


}
