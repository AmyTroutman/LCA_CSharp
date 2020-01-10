using System;

namespace PigLatin
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Give me a word and I'll translate it into pig latin.");
            string englishWord = Console.ReadLine();

            //char checker
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            //grab first letter
            string firstLetter = englishWord.Substring(0, 1);

            //grab second letter
            string lastLetter = englishWord.Substring(englishWord.Length -1);

            //begin building piglatin word
            //no vowels in word
            if (englishWord.IndexOfAny(vowels) == -1)
            {
                Console.WriteLine(englishWord + "ay");
            }
            //first letter is a vowel
            else if (firstLetter.IndexOfAny(vowels) == 0)
            {
                //last letter is a vowel
                if (lastLetter.IndexOfAny(vowels) == 0)
                {
                    Console.WriteLine(englishWord + "yay");
                }
                //last letter is a consonant
                else
                {
                    Console.WriteLine(englishWord + "ay");
                }
            }
            //first letter is a consonant
            else
            {
                string pigWord = englishWord.Substring(1, englishWord.Length - 1) + firstLetter;
                Console.WriteLine(pigWord + "ay");
                
            }
            Console.ReadKey();
        }
    }
}
