using System;

namespace PigLatin
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* There's definitely a way to have it repeat without just queuing
             * a bunch of "PigLatin()". Would I write another function that asks if you want to translate another word?*/
            PigLatin();
            //Repeat();
            Console.ReadKey();
        }

        //Would this be close to how I would repeat the function PigLatin but still be able to exit?
        /*static void Repeat()
         * {
         * Console.WriteLine("Do you want to translate another word? y/n");
         * char answer = Console.ReadLine();
         * if (answer == "y")
         *  {
         *  run PigLatin();
         *  }
         *  else
         *  {
         *  Console.ReadKey();
         *  }
         * }
        */

        static void PigLatin()
        {
                
                Console.WriteLine("Give me a word and I'll translate it into Pig Latin.");
                string englishWord = Console.ReadLine();

                //vowel checker
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

                //grab first letter
                string firstLetter = englishWord.Substring(0, 1);

                //grab last letter
                string lastLetter = englishWord.Substring(englishWord.Length - 1);

                //begin building piglatin word
                //no vowels in word
                if (englishWord.IndexOfAny(vowels) == -1)
                {
                    Console.WriteLine(englishWord + "ay" + " is the Pig Latin translation of " + englishWord);
                }
                //first letter is a vowel
                else if (firstLetter.IndexOfAny(vowels) == 0)
                {
                    //last letter is a vowel
                    if (lastLetter.IndexOfAny(vowels) == 0)
                    {
                        Console.WriteLine(englishWord + "yay" + " is the Pig Latin translation of " + englishWord);
                    }
                    //last letter is a consonant
                    else
                    {
                        Console.WriteLine(englishWord + "ay" + " is the Pig Latin translation of " + englishWord);
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
                    Console.WriteLine(pigWord + " is the Pig Latin translation of " + englishWord);

                }

              
        }
        
    }
}
