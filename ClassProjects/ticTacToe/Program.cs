using System;

namespace ticTacToe
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //my methods
            static void placeMarker();
            static bool isHorizontalWin();
            static bool isVerticalWin();
            static bool isDiagonalWin();
            static bool hasWon();
            static bool isTie();
            static void printBoard();
            //the board
            String[] row0 = new string[3];
            String[] row1 = new string[3];
            String[] row2 = new string[3];
            String[][] board = new string[3][];
            board[0] = row0;
            board[2] = row1;
            board[2] = row2;

            //current player's turn
            String currentPlayer = "X";

            //changes current player
            if (currentPlayer == "X")
            {
                currentPlayer = "O";
                Console.WriteLine(currentPlayer);
            }
            else
            {
                currentPlayer = "X";
                Console.WriteLine(currentPlayer);
            }


        }
     
    }
}
