﻿using System;

namespace RockPaperScissors
{
    //my array for the random picker to pick from
    public enum Shapes { Rock, Paper, Scissors }


    class MainClass
    {
        
        public static void Main()
        {
            //randomly assign a value to myHand from Shapes. 
            Shapes myHand = (Shapes)(new Random()).Next(0, 3);
            Console.WriteLine("Rock, Paper, Scissors!");
            string yourHand = Console.ReadLine().ToLower();
            Console.WriteLine("I choose " + myHand);
            CompareHands(yourHand, myHand);
        }

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

            //do you want to play again? Because who doesn't want to play again??
            
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


