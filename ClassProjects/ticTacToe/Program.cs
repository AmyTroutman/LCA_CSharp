using System;

namespace ticTacToe
{
    class MainClass
    {
        
        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
                new string[] {" ", " ", " "},
                new string[] {" ", " ", " "},
                new string[] {" ", " ", " "}
        };
        public static int row;
        public static int column;

        public static void Main()
        {

            do
            {
                DrawBoard();
                GetInput();
                PlaceMark(row, column);


            } while (!CheckForWin() && !CheckForTie());
       
            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            column = int.Parse(Console.ReadLine());
        }

        public static void PlaceMark(int row, int column)
        {
            // your code goes here
            if (playerTurn == "X")
            {
                board[row][column] = "X";
                playerTurn = "O";
            }
            else if (playerTurn == "O")
            {
                board[row][column] = "O";
                playerTurn = "X";
            }
        }
        
        public static bool CheckForWin()
        {
            // your code goes here

            return false;
        }

        public static bool CheckForTie()
        {
            // your code goes here

            return false;
        }

        public static bool HorizontalWin()
        {
            // your code goes here

            return false;
        }

        public static bool VerticalWin()
        {
            // your code goes here

            return false;
        }

        public static bool DiagonalWin()
        {
            // your code goes here

            return false;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }

    }
}


