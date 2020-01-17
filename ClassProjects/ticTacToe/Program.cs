using System;

namespace ticTacToe
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //the board
            String[] row0 = new string[3];
            String[] row1 = new string[3];
            String[] row2 = new string[3];
            String[][] board = new string[3][];
            board[0] = row0;
            board[2] = row1;
            board[2] = row2;

            //current player's turn
            static String currentPlayer = "X";

            //changes current player
            if (currentPlayer == "X")
            {
                currentPlayer = "O";

            }
            else
            {
                currentPlayer = "X";

            }
            //my methods
            placeMarker(currentPlayer);
            //isVerticalWin();
            //isDiagonalWin();
            //hasWon();
            //isTie();
            //printBoard();
            
            Console.WriteLine("Let's play tic tac toe! Give me the coordinates of where you'd like mark. (0 0 is the top left corner, 1 1 is the middle square, 2 2 is the bottom right corner.)");

            static void placeMarker(string currentPlayer)
                {
                Console.WriteLine("It's " + currentPlayer+ "'s turn! Where do you want to play?");
                String mark = Console.ReadLine();
            }
        }
     
    }
}
