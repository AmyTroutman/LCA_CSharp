using System;

namespace NonRepeating
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "seat";
            string word2 = "lollipop";
            string word3 = "house";
            string word4 = "hello";
            stringCheck(word1);
            stringCheck(word2);
            stringCheck(word3);
            stringCheck(word4);
        }


        public static void stringCheck(string word)
        {
            int temp = -1;
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = i + 1; j < word.Length; j++)
                {
                    if (word[i] == word[j])
                    {
                        temp = i;
                        break;
                    }
                }
                if (temp != -1)
                {
                    break;
                }
            }
            Console.WriteLine(temp);
        }
    }
}
