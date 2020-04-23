using System;

namespace DuplicateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ogArray = new int[] { 1, 2, 3, 4, 5 };
            int[] newArray = new int[ogArray.Length*2];
            for (int i = 0; i < newArray.Length; i++)
            {
                if(i < ogArray.Length)
                {
                    newArray[i] = ogArray[i];
                }
                else
                {
                    newArray[i] = ogArray[i - 5];
                }
            }
            foreach(var i in newArray)
            {
                Console.WriteLine(newArray[i]);
            }
        }
    }
}
