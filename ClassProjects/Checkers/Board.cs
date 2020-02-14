using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkers_Sample
{
    #region Board Class
    public class Board
    {
        public List<Checker> checkers { get; private set; }

        #region Constructor
        public Board()
        {
            checkers = new List<Checker>();
            for (int r = 0; r < 3; r++)
            {
                for (int i = 0; i < 8; i += 2)
                {
                    Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);
                    checkers.Add(c);
                }
                for (int i = 0; i < 8; i += 2)
                {
                    Checker c = new Checker(Color.Black, (r + 5), r % 2 + i);
                    checkers.Add(c);
                }
            }
        }
        #endregion

        #region Methods
        public Checker GetChecker(Position source)
        {
            //The linq way.            
            return checkers.Find(x => x.Position.Row == source.Row && x.Position.Column == source.Column);

            //the foreach way.
            //foreach (Checker c in checkers)
            //{
            //    //Checks each checker on the board to find a match to the input
            //    if (c.Position.Row == source.Row && c.Position.Column == source.Column)
            //    {
            //        return c;
            //    }                
            //}
            //return null;
        }

        public void MoveChecker(Checker checker, Position destination)
        {
            Checker c = new Checker(checker.Team, destination.Row, destination.Column);
            //Add the checker to our list of checkers.
            checkers.Add(c);
            checkers.Remove(checker);
        }

        public void RemoveChecker(Checker checker)
        {
            //removes checker if there is a checker
            if (checker != null)
            {
                checkers.Remove(checker);
            }
        }

        #endregion
    }

    #endregion


}