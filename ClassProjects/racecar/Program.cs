using System;

namespace racecar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a word and I'll tell you if has no unique characters.");
            string word = Console.ReadLine();
            bool uniqueChars = true;
            foreach (char character in word.ToCharArray())
            {
                int first = word.IndexOf(character);
                int last = word.LastIndexOf(character);
                if (word.IndexOf(character) != word.LastIndexOf(character))
                {
                    uniqueChars = false;
                    break;
                }             
            }
            if (uniqueChars)
            {
                Console.WriteLine($"Every character in {word} is unique!");
            }
            else
            {
                Console.WriteLine($"At least one character in {word} repeats.");

            }
        }  
    }
}
