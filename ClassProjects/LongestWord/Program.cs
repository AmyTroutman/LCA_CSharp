using System;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is a sentence that has a lot of words. Some are long some are short some are mediocre some are meh.";
            string[] words = sentence.Split(" ");
            string longestWord = string.Empty;

            foreach(var word in words)
            {
                if(word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine($"The longest word is {longestWord}.");
        }
    }
}
