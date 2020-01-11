using System;

namespace PigLatin
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* can I loop this? So instead of having to rerun, it can keep
             * accepting new words? Like a function? Or is "public satic
             * void Main..." the function? */
            Console.WriteLine("Give me a word and I'll translate it into Pig Latin.");
            string englishWord = Console.ReadLine();

            //vowel checker
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            //grab first letter
            string firstLetter = englishWord.Substring(0, 1);

            //grab last letter
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
            //First letter is a consonant. Accounts for multiple consonants!!
            else
            {
                //Finds the first vowel
                int firstVowel = englishWord.IndexOfAny(vowels);
                //Grabs the consonants that precede the first vowel
                string consonants = englishWord.Substring(0, firstVowel);
                //Grabs the letters after the last leading consonant
                string clipWord = englishWord.Substring(firstVowel);
                //Builds the pigLatin word. 
                string pigWord = clipWord + consonants + "ay";
                Console.WriteLine(englishWord + " translated into Pig Latin is " +pigWord);
                
            }
            
            Console.ReadKey();
        }
    }
}
