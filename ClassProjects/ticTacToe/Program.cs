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
        public static bool win;
        public static string winner;



        public static void Main()
        {

            do
            {
                DrawBoard();
                GetInput();
                PlaceMark(row, column);
            } while (!CheckForWin(win) && !CheckForTie());

            if (CheckForTie() == true)
            {
                DrawBoard();
                Console.WriteLine("It's a tie!");
            }

            if (CheckForWin(win) == true)
            {
                DrawBoard();
                Console.WriteLine(winner + " is the winner!");
            }

            // leave this command at the end so your program does not
            //close automatically
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
                //check if spot is empty
                if (board[row][column] == " ")
                {
                    board[row][column] = "X";
                    playerTurn = "O";
                }
                else
                {
                    Console.WriteLine("That spot is taken! Try another.");


                }
            }
            else if (playerTurn == "O")
            {
                if (board[row][column] == " ")
                {
                    board[row][column] = "O";
                    playerTurn = "X";
                }
                else
                {
                    Console.WriteLine("That spot is taken! Try another.");

                }
            }
        }

        public static bool CheckForWin(bool win)
        {

            HorizontalWin();
            VerticalWin();
            DiagonalWin();
            if (win == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool CheckForTie()
        {

            //There's defintely a better way to do this...
            //check if the board is full
            if (board[0][0] != " ")
            {
                if (board[0][1] != " ")
                {
                    if (board[0][2] != " ")
                    {
                        if (board[1][0] != " ")
                        {

                            if (board[1][1] != " ")
                            {

                                if (board[1][2] != " ")
                                {

                                    if (board[2][0] != " ")
                                    {

                                        if (board[2][1] != " ")
                                        {
                                            if (board[2][2] != " ")
                                            {
                                                return true;
                                            }
                                            else
                                            {
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }

                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

        }



        public static void HorizontalWin()
        {
            // having figured out win and tie checker bools, I think I
            // know how to do these as bool instead of void, but it's Sunday
            //and I still have to fix Rock Paper Scissors.
            if (board[0][0] == "X")
            {
                if (board[0][1] == "X")
                {
                    if (board[0][2] == "X")
                    {
                        win = true;
                        winner = "X";
                        //Console.Write(winner + " is the winner!");
                    }
                    else
                    {
                        win = false;
                    }
                }
                else
                {
                    win = false;
                }
            }
            else
            {
                win = false;
            }
            if (board[1][0] == "X")
            {
                if (board[1][1] == "X")
                {
                    if (board[1][2] == "X")
                    {
                        win = true;
                        winner = "X";
                        //Console.Write(winner + " is the winner!");
                    }
                    else
                    {
                        win = false;

                    }
                }
                else
                {
                    win = false;
                }
            }
            else
            {
                win = false;
            }
            if (board[2][0] == "X")
            {
                if (board[2][1] == "X")
                {
                    if (board[2][2] == "X")
                    {
                        win = true;
                        winner = "X";
                       // Console.Write(winner + " is the winner!");
                    }
                    else
                    {
                        win = false;
                    }
                }
                else
                {
                    win = false;
                }
            }
            else
            {
                win = false;
            }
            if (board[0][0] == "O")
            {
                if (board[0][1] == "O")
                {
                    if (board[0][2] == "O")
                    {
                        win = true;
                        winner = "O";
                        //Console.Write(winner + " is the winner!");
                    }
                    else
                    {
                        win = false;
                    }
                }
                else
                {
                    win = false;
                }
            }
            else
            {
                win = false;
            }
            if (board[1][0] == "O")
            {
                if (board[1][1] == "O")
                {
                    if (board[1][2] == "O")
                    {
                        win = true;
                        winner = "O";
                        //Console.Write(winner + " is the winner!");
                    }
                    else
                    {
                        win = false;
                    }
                }
                else
                {
                    win = false;
                }
            }
            else
            {
                win = false;
            }
            if (board[2][0] == "O")
            {
                if (board[2][1] == "O")
                {
                    if (board[2][2] == "O")
                    {
                        win = true;
                        winner = "O";
                        //Console.Write(winner + " is the winner!");
                    }
                    else
                    {
                        win = false;
                    }
                }
                else
                {
                    win = false;
                }
            }
            else
            {
                win = false;

            }
        }

        public static void VerticalWin()
        {
            // your code goes here

            if (board[0][0] == "X")
            {
                if (board[1][0] == "X")
                {
                    if (board[2][0] == "X")
                    {
                        win = true;
                        winner = "X";
                        //Console.Write(winner + " is the winner!");
                    }
                    else
                    {
                        win = false;
                    }
                }
                else
                {
                    win = false;
                }
            }
            else
            {
                win = false;
            }
            if (board[0][1] == "X")
            {
                if (board[1][1] == "X")
                {
                    if (board[2][1] == "X")
                    {
                        win = true;
                        winner = "X";
                        //Console.Write(winner + " is the winner!");
                    }
                    else
                    {
                        win = false;

                    }
                }
                else
                {
                    win = false;
                }
            }
            else
            {
                win = false;
            }
            if (board[0][2] == "X")
            {
                if (board[1][2] == "X")
                {
                    if (board[2][2] == "X")
                    {
                        win = true;
                        winner = "X";
                        //Console.Write(winner + " is the winner!");
                    }
                    else
                    {
                        win = false;
                    }
                }
                else
                {
                    win = false;
                }
            }
            else
            {
                win = false;
            }
            if (board[0][0] == "O")
            {
                if (board[1][0] == "O")
                {
                    if (board[2][0] == "O")
                    {
                        win = true;
                        winner = "O";
                        //Console.Write(winner + " is the winner!");
                    }
                    else
                    {
                        win = false;
                    }
                }
                else
                {
                    win = false;
                }
            }
            else
            {
                win = false;
            }
            if (board[0][1] == "O")
            {
                if (board[1][1] == "O")
                {
                    if (board[2][1] == "O")
                    {
                        win = true;
                        winner = "O";
                        //Console.Write(winner + " is the winner!");
                    }
                    else
                    {
                        win = false;
                    }
                }
                else
                {
                    win = false;
                }
            }
            else
            {
                win = false;
            }
            if (board[0][2] == "O")
            {
                if (board[1][2] == "O")
                {
                    if (board[2][2] == "O")
                    {
                        win = true;
                        winner = "O";
                        //Console.Write(winner + " is the winner!");
                    }
                    else
                    {
                        win = false;
                    }
                }
                else
                {
                    win = false;
                }
            }
            else
            {
                win = false;

            }
        }

        public static void DiagonalWin()
        {
            // your code goes here

            if (board[0][0] == "X")
            {
                if (board[1][1] == "X")
                {
                    if (board[2][2] == "X")
                    {
                        win = true;
                        winner = "X";
                        //Console.Write(winner + " is the winner!");
                    }
                    else
                    {
                        win = false;
                    }
                }
                else
                {
                    win = false;
                }
            }
            else
            {
                win = false;
            }
            if (board[0][2] == "X")
            {
                if (board[1][1] == "X")
                {
                    if (board[2][0] == "X")
                    {
                        win = true;
                        winner = "X";
                        //Console.Write(winner + " is the winner!");
                    }
                    else
                    {
                        win = false;

                    }
                }
                else
                {
                    win = false;
                }
            }
            else
            {
                win = false;
            }

            if (board[0][0] == "O")
            {
                if (board[1][1] == "O")
                {
                    if (board[2][2] == "O")
                    {
                        win = true;
                        winner = "O";
                        //Console.Write(winner + " is the winner!");
                    }
                    else
                    {
                        win = false;
                    }
                }
                else
                {
                    win = false;
                }
            }
            else
            {
                win = false;
            }
            if (board[0][2] == "O")
            {
                if (board[1][1] == "O")
                {
                    if (board[2][0] == "O")
                    {
                        win = true;
                        winner = "O";
                        //Console.Write(winner + " is the winner!");
                    }
                    else
                    {
                        win = false;
                    }
                }
                else
                {
                    win = false;
                }
            }
            else
            {
                win = false;
            }
        }

        public static void DrawBoard()
        {

            Console.WriteLine("");
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }

    }
}


