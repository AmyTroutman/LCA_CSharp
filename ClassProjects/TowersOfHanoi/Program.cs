using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    
    class MainClass
    {
        
        private static Dictionary<string, Stack<int>> tower = new Dictionary<string, Stack<int>>();

        static void Main(string[] args)
        {
            //establishing the board. Verbose names so I can visualize it.
            Stack<int> ring1 = new Stack<int>();
            Stack<int> ring2 = new Stack<int>();
            Stack<int> ring3 = new Stack<int>();
            ring1.Push(4);
            ring1.Push(3);
            ring1.Push(2);
            ring1.Push(1);
            tower.Add("A", ring1);
            tower.Add("B", ring2);
            tower.Add("C", ring3);

            Console.WriteLine("Welcome to Towers of Hanoi!!! The aim of the game is to get all the numbers to tower C. The only rule is that you cannot place a larger number on top of a smaller number. Good luck!");

            do
            {
                Console.Clear();
                PrintBoard();
                Console.WriteLine("Which tower would you like to move from?");
                string from = Console.ReadLine().ToUpper();
                Console.WriteLine("Which tower would you like to move to?");
                string to = Console.ReadLine().ToUpper();

                if (CanDo(from, to))
                {
                    tower[to].Push(tower[from].Pop());
                }
                else
                {
                    Console.WriteLine("...Yeah, no, I can't do that.");
                    //I've never used this method, so mayhaps change it
                    Console.WriteLine("You do know how to play, right? Press any key to prove you can do this.");
                    Console.ReadKey();
                }

            } while (!IsWin());

            Console.Clear();
            PrintBoard();
            Console.WriteLine("You only bloody did it! Well done!");
            Console.ReadKey();
        }

        private static bool CanDo(string from, string to)
        {
            //check for empty input
            if (from == "" || to == "")
            {
                return false;
            }            
            //is there anything to move from the tower
            else if (tower[from].Count == 0)
            {
                return false;
            }
            //why are you moving from and to the same tower??
            else if (to == from)
            {                
                return false;
            }                        
            //are we going to an empty tower?
            else if (tower[to].Count != 0)
            {
                //making sure we're not bigger than what's on the tower
                if (tower[from].Peek() > tower[to].Peek())
                {
                    return false;
                }               
                return true;
            }
            else //all clear, kid!
            {
                return true;
            }
        }

        private static bool IsWin()
        {
            //Win when all four are in tower C
            if (tower["C"].Count == 4)
            {
                return true;
            }
            return false;
        }

        private static void PrintBoard()
        {
            foreach (var item in tower)
            {                
                Console.Write($"\n{item.Key}: ");
                var numbers = item.Value.ToArray();                
                for (int i = numbers.Length; i > 0; i--)
                {
                    Console.Write(numbers[i - 1] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
