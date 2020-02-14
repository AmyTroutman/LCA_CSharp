using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkers_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Game newGame = new Game();
            newGame.Start();
            Console.ReadKey();
        }
    }

    public enum Color { White, Black }

#region Position Struct
    public struct Position
    {
        public int Row { get; private set; }
        public int Column { get; private set; }
        public Position(int row, int col)
        {
            Row = row;
            Column = col;
        }
    }
#endregion
}