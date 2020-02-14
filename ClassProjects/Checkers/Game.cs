using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkers_Sample
{
    #region Game Class
    public class Game
    {
        private Board board;

        public Game()
        {
            this.board = new Board();
        }

        public bool CheckForWin()
        {
            //more linq!
            return (board.Checkers.All(x => x.Team == Color.White) || board.Checkers.All(x => x.Team == Color.Black));
        }

        public void Start()
        {
            DrawBoard();
           
            while (!CheckForWin())
            {
                ProcessInput();
            }
            Console.WriteLine("You won!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public bool IsLegalMove(Color player, Position source, Position destination)
        {
            //These check that the destination is valid
            //Both the source position and the destination position must be integers between 0 and 7
            if (source.Row < 0 || source.Row > 7 || source.Column < 0 || source.Column > 7
                || destination.Row < 0 || destination.Row > 7 || destination.Column < 0
                || destination.Column > 7) return false; 

            //The row distance between the destination position and the source position must be larger than 0 AND less than or equal to 2
            int rowDistance = Math.Abs(destination.Row - source.Row);           
            int colDistance = Math.Abs(destination.Column - source.Column);

            //Checks to make sure that the checker cannot move in a straight line.
            if (colDistance == 0 || rowDistance == 0) return false;

            //Checks the diagonal of the checker.
            if (rowDistance / colDistance != 1) return false;

            //Checks that destination is not further than 2 rows.
            if (rowDistance > 2) return false; 

            //These check for Checkers in source and destination
            Checker c = board.GetChecker(source);

            //Checks if there is a checker at the source position
            if (c == null)  
            {
                return false; 
            }

            c = board.GetChecker(destination);
            //Checks if there's a checker at the destination
            if (c != null) 
            {
                return false; 
            }
            // If we get here, that means the source position has a checker AND the destination position is empty AND destination.Row != source.Row AND destination.Column != source.Destination
            //Checks that a jump is valid by calling IsCapture. If IsCapture is true, then the jump is true.  
            if (rowDistance == 2)
            {
                if (IsCapture(source, destination))
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
                return true;
            }
        }

        public bool IsCapture(Position source, Position destination)
        {
            //TODO: something in here isn't working consistently
            
            //TODO: what is this? would this work better than Math?
            // |destination.Row - source.Row|==2 && |destination.Column - source.Column|==2
            int rowDistance = Math.Abs(destination.Row - source.Row);
            int colDistance = Math.Abs(destination.Column - source.Column);
            
            if (rowDistance == 2 && colDistance == 2)
            {
                //Finds the middle square
                int row_mid = (destination.Row + source.Row) / 2;                
                int col_mid = (destination.Column + source.Column) / 2;

                //Hold onto that spot
                Position p = new Position(row_mid, col_mid);

                //Grab the the middle checker
                Checker c = board.GetChecker(p);

                //Get that jumping checker
                Checker player = board.GetChecker(source);

                //no checker to jump
                if (c == null) 
                {
                    return false;
                }
                else
                {
                    //make sure you're not jumping you're own checker
                    if (c.Team == player.Team) 
                    {
                        return false; 
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
        }

        public Checker GetCaptureChecker(Position source, Position destination)
        {
            if (IsCapture(source, destination))
            {                
                // there must be a piece in the middle of the source and the destination
                int row_mid = (destination.Row + source.Row) / 2;               
                int col_mid = (destination.Column + source.Column) / 2;               
                Position p = new Position(row_mid, col_mid);
                Checker c = board.GetChecker(p);
                return c;
            }
            return null;

        }

        public void ProcessInput()
        {
            //Which checker do you want to move?
            Console.WriteLine("Select a checker to move (Row, Column):");
            string[] src = Console.ReadLine().Split(','); 

            //Where do you want that checker to go?
            Console.WriteLine("Select a square to move to (Row, Column):");
            string[] dest = (Console.ReadLine().Split(',')); 
           
            Position from = new Position(int.Parse(src[0]), int.Parse(src[1]));
            Position to = new Position(int.Parse(dest[0]), int.Parse(dest[1]));
            

            //Get the checker at the source position:
            Checker srcChecker = board.GetChecker(from);

            //If there is no checker at the source position notify the user
            if (srcChecker == null )
            {
                Console.WriteLine("Invalid source position, try again.");
            }
            //If there is a checker at the source position then check if the move from the source position to the destination position is a legal move
            else
            {
                if (IsLegalMove(srcChecker.Team, from, to))
                {
                    if (IsCapture(from, to))
                    {
                        //Grabbing the jumped checker
                        Checker jumpChecker = this.GetCaptureChecker(from, to);

                        //Removing the jumped checker
                        board.RemoveChecker(jumpChecker);

                        //move the active checker to it's new spot
                        board.MoveChecker(srcChecker, to);
                    }                   
                    board.MoveChecker(srcChecker, to);
                }
                else
                {
                    Console.WriteLine("Invalid move. Check the source and destination.");
                }
            }
            DrawBoard();
        }

        public void DrawBoard()
        {
            String[][] grid = new String[8][];
            for (int r = 0; r < 8; r++)
            {
                grid[r] = new String[8];
                for (int c = 0; c < 8; c++)
                {
                    grid[r][c] = " ";
                }
            }
            foreach (Checker c in board.Checkers)
            {
                grid[c.Position.Row][c.Position.Column] = c.Symbol;
            }

            Console.WriteLine("   0   1   2   3   4   5   6   7");
            Console.Write("  ");
            for (int i = 0; i < 32; i++)
            {
                Console.Write("\u2501");
            }
            Console.WriteLine();

            for (int r = 0; r < 8; r++)
            {
                Console.Write($"{r} ");
                for (int c = 0; c < 8; c++)
                {
                    Console.Write($" {grid[r][c]} \u2503"); 
                }
                Console.WriteLine();
                Console.Write("  ");
                for (int i = 0; i < 32; i++)
                {
                    Console.Write("\u2501");
                }
                Console.WriteLine();
            }
        }
    }

    #endregion
}