using System;

namespace Mastermind
{
    
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
            } while (isWin == false);
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
            int colorCorrect = 0;
            int posCorrect = 0;

            for (int i = 0; i < 2; i++)
            {
                if (password[1-i] == guess[i]) colorCorrect++;
                if (password[i] == guess[i]) posCorrect++;
            }
           
            Console.WriteLine("Your hint: " + posCorrect + "-" + colorCorrect);

            if (posCorrect == 2 && colorCorrect == 2)
            {
                isWin = true;
                Console.WriteLine("yay");
                Console.WriteLine("oh wow");
                Console.WriteLine("you're so smart");
                Console.WriteLine("you beat me");
                Console.WriteLine("cool");
                Console.WriteLine("that was fun /s");
                Console.WriteLine("smiley face");
                
            }
            else
            {
                isWin = false;
            }
        }

        

    }


}
