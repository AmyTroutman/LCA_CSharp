using System;

namespace PigLatin
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give me a word and I'll translate it into pig latin.");
            string EnglishWord = Console.ReadLine();
            //check for vowel at end and beginning. add "yay" if true.
            if (EnglishWord.StartsWith("a", "e")) && (EnglishWord.EndsWith("a", "e", "i", "o", "u"))
            {
                Console.WriteLine(EnglishWord + "yay");
            }
            //check for for vowel at start, consonant at end. add "ay" if true.

            //check for any vowels. if none, add "ay" to the end. IndexOfAny(Char[])

            //check for consonant at start and end, and vowels in between. if true, move consonants before vowel to end of word and add "ay".
        }
    }
}
