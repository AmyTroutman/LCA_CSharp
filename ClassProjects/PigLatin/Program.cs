using System;

namespace PigLatin
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            PigLatin();
        }

        static void PigLatin()
        {
            //Do you want to play a game?
                Console.WriteLine("Give me a word or sentence and I'll translate it into Pig Latin.");
                string sentence = Console.ReadLine();

                //vowel checker
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            //if given a sentence, this splits it into individual words
            /* So this will do each word, but since I have only told it to output without saving the word, it outputs the whole translation sentence for each word. So I either remove the extra wording or figure out how to save each word to it's own string and do a final concatenation at the end. Or unsplit the string, is that a thing??? Surely?? There has to be another way. */
            string[] splitSentence = sentence.Split(' ');

            foreach (string englishWord in splitSentence)
            {

                //grab first letter
                string firstLetter = englishWord.Substring(0, 1);

                //grab last letter
                string lastLetter = englishWord.Substring(englishWord.Length - 1);

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
                    //Builds the pigLatin word, because reasons. 
                    string pigWord = clipWord + consonants + "ay";
                    Console.WriteLine(pigWord);

                }
               
            }
            //do you want to play again? Because who doesn't want to play again??
            Console.WriteLine("Do you want to translate another word? y/n");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                PigLatin();
            }
            else
            {
                Console.ReadKey();
            }
        }
        
    }
}
