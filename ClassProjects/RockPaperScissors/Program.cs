using System;

namespace RockPaperScissors
{
    //my enum for the random picker to pick from
    public enum Shapes { Rock, Paper, Scissors }


    class MainClass
    {
        //da driver
        public static void Main()
        {
            CompareHands(YourHand(), MyHand());
            PlayAgain();
        }

        //Randomly assigns a shape for the computer to throw
        public static Shapes MyHand()
        {
            Shapes myHand = (Shapes)(new Random()).Next(0, 3);
            Console.WriteLine("I choose " + myHand);
            return myHand;
        }

        //Gets input from user, checks and returns if valid, else prompts for valid input.
        public static string YourHand()
        {
            bool valid;
            Console.WriteLine("Rock, Paper, Scissors!");
            string yourHand = Console.ReadLine().ToLower();
            do
            {
                
                if(yourHand == "rock")
                {
                    valid = true;
                }
                else if(yourHand == "paper")
                {
                    valid = true;
                }
                else if(yourHand == "scissors")
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Please enter rock or paper or scissors.");
                    yourHand = Console.ReadLine().ToLower();
                    valid = false;
                }
            } while (valid == false);
            return yourHand;
        }

        //Runs yourHand and myHand through a switch to compare and check for winner
        public static void CompareHands(string yourHand, Shapes myHand)
        {
            //The swtich! 
            switch (myHand)
            {
                //if Rock is picked by the randomizer, check it against yourHand
                case Shapes.Rock:
                    if (yourHand == "rock")
                    {
                        //let the player know my choice
                        
                        //declare if win, loss, or tie
                        Console.WriteLine("It's a tie!");
                    }
                    else if (yourHand == "paper")
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (yourHand == "scissors")
                    {
                        Console.WriteLine("I win!");
                    }
                    break;

                //if Paper is picked by the randomizer, check it against yourHand
                case Shapes.Paper:
                    if (yourHand == "rock")
                    {
                        Console.WriteLine("I win!");
                    }
                    else if (yourHand == "paper")
                    {
                        Console.WriteLine("It's a tie!");
                    }
                    else if (yourHand == "scissors")
                    {
                        Console.WriteLine("You win!");
                    }
                    break;

                //if scissors is picked by the randomizer, check it against yourHand
                case Shapes.Scissors:
                    if (yourHand == "rock")
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (yourHand == "paper")
                    {
                        Console.WriteLine("I win!");
                    }
                    else if (yourHand == "scissors")
                    {
                        Console.WriteLine("It's a tie!");
                    }
                    break;
                default:
                    Console.WriteLine(myHand);
                    break;
            }
        }

        //do you want to play again? Because who doesn't want to play again??
        public static void PlayAgain()
        {
            Console.WriteLine("Do you want to play another hand? y/n");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Press any key to end the game.");
                Console.ReadKey();
            }
        }
    }
}


