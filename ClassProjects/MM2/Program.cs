using System;
using System.Collections.Generic;

namespace MM2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[] { "red", "blue", "yellow" };
            List<string> computerColors = new List<string>();
            List<string> userColors = new List<string>();
            string answer = Console.ReadLine().ToLower();
            string[] usercolors = answer.Split();

            Random random = new Random();
            computerColors.Add(colors[random.Next(0, 2)]);
            computerColors.Add(colors[random.Next(0, 2)]);

            bool isPlaying = true;

            while (isPlaying)
            {
                Console.WriteLine("What is the first color?");
                userColors.Add(Console.ReadLine().ToLower().Trim());
                Console.WriteLine("What is the second color?");
                userColors.Add(Console.ReadLine().ToLower().Trim());

                //Win condition
                if (usercolors[0].Equals(computerColors[0]) && usercolors[1].Equals(computerColors[1]))
                {
                    //win
                }
                //right color
                else if (usercolors[0].Equals(computerColors[0]) || usercolors[1].Equals(computerColors[1]))
                {
                    //give hint:color right, 
                }
                else if(userColors.Contains(computerColors[0]) || userColors.Contains(computerColors[1]))
                {
                    if (userColors[0].Equals(computerColors[1]))
                    {

                    }
                }
            }
            
            
        }
    }
}
