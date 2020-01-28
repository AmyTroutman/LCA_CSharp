using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    
    class MainClass
    {
        private static Dictionary<string, Stack<int>> board = new Dictionary<string, Stack<int>>();
        static void Main(string[] args)
        {
            Stack<int> ring1 = new Stack<int>();
            Stack<int> ring2 = new Stack<int>();
            Stack<int> ring3 = new Stack<int>();
            ring1.Push(4);
            ring1.Push(3);
            ring1.Push(2);
            ring1.Push(1);
            board.Add("A", ring1);
            board.Add("B", ring2);
            board.Add("C", ring3);
            
            do
            {
                Console.Clear();
                PrintBoard();
                Console.WriteLine("Which tower would you like to move from?");
                string from = Console.ReadLine().ToUpper();
                Console.WriteLine("Which tower would you like to move to?");
                string to = Console.ReadLine().ToUpper();

                if (IsMoveValid(from, to))
                {
                    // use the stack.Push(object) to move the peg from the original position to the new position
                    // you can substitute the "object" in the push method with the stack.Pop() 
                    // ex:  stack.Push(stack.Pop());
                 
                    board[to].Push(board[from].Pop());
                }
                else
                {
                    Console.WriteLine("Move was not valid.");
                    //I've never used this method, so mayhaps change it
                    Console.WriteLine("Press any key to try again.");
                    Console.ReadKey();
                }

            } while (!CheckWin());

            Console.Clear();
            PrintBoard();
            Console.WriteLine("You win!");
            Console.ReadKey();
        }

        private static bool IsMoveValid(string from, string to)
        {
            // if the count is zero, it means the tower has nothing to move, and you can't move nothing
            if (board[from].Count == 0)
            {
                // nothing in this tower
                return false;
            }
            else if (to == from)
            {
                // can't move a peg from and to the same tower
                return false;
            }
            // check that the destination tower is not empty before using Peek, otherwise it will throw an error
            else if (board[to].Count != 0)
            {
                // can't move a larger number on top of a smaller number
                if (board[from].Peek() > board[to].Peek())
                {
                    return false;
                }

                // if the above expression is false, it assumes the move is legal
                return true;
            }
            else // move is legal
            {
                return true;
            }
        }

        private static bool CheckWin()
        {
            // How many items must there be in Stack "C" to win?
            if (board["C"].Count == 4)
            {
                return true;
            }
            return false;
        }

        private static void PrintBoard()
        {
            foreach (var item in board)
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
