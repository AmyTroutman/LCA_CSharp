using System;

namespace Mastermind
{
    //ohhh, I should probably be using a dictionary. 0:blue, 1:green, 2:oranges
    
    class MainClass

    {
        public static string[] guess = new string[2];
        public static string[] password = new string[2];
        public static bool isWin = false;
        public static void Main()
        {
            Console.WriteLine("Let's play Mastermind! I've chosen two colors from a choice of green, blue, and orange. Guess the right colors in the right order and you win!");

            //Answer out here so it doesn't make a new password with every loop!
            Answer(password);
            do
            {
                Input(guess);
                Match(password, guess);
            } while (!Win(isWin));
            Console.ReadKey();

        }
        public static void Input(string[] guess)
        {

            Console.WriteLine("What is your guess?");
            string input = Console.ReadLine();

            string[] splitInput = input.Split(' ');
            //perma-storing that data, baby
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
            if (guess[0][1] == password[0][1])
            {
                isWin = true;
                Console.WriteLine("You win!");
                Win(isWin);
            }
            else
            {
                for (int i = 0; i < guess.Length; i += 1)
                {
                    //how can I check all four scenarios??
                    Console.WriteLine(guess[i][i] == password[i][i] ? "One is correct!" : "One is incorrect");

                }                
            }
            
            

            //test that password is keeping value
            /*foreach (string word in password)
            {
                Console.WriteLine("pword " + word);
            }
            //test that guess data was stored
            foreach (string word in guess)
            {
                Console.WriteLine("gword " + word);
            }
           */
        }
        public static bool Win(bool isWin)
        {

            if (isWin == true)
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
