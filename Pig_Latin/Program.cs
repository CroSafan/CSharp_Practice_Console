using System;

namespace Pig_Latin
{
    internal class Program
    {
        /// <summary>
        /// Pig Latin - Pig Latin is a game of alterations played on the English language game. To
        /// create the Pig Latin form of an English word the initial consonant sound is transposed to
        /// the end of the word and an ay is affixed (Ex.: "banana" would yield anana-bay). Read
        /// Wikipedia for more information on rules.
        /// </summary>

        private static void Main(string[] args)
        {
            Console.WriteLine(PigLatin("pig"));
            Console.Read();
        }

        public static string PigLatin(string inputString)
        {
            string memString = "";

            if (inputString.ToLower()[0] == 'o' || (inputString.ToLower()[0] == 'a') || (inputString.ToLower()[0] == 'e') || (inputString.ToLower()[0] == 'i') || (inputString.ToLower()[0] == 'o'))
            {
                return inputString + "way";
            }
            else
            {
                for (int i = 0; i < inputString.Length; i++)
                {
                    //checking if the first position isn't a vowel, if it isn't a vowel first store it somewhere else then remove it
                    if (inputString.ToLower()[0] != 'a' && inputString.ToLower()[0] != 'e' && inputString.ToLower()[0] != 'i' && inputString.ToLower()[0] != 'o' && inputString.ToLower()[0] != 'u')
                    {
                        memString += inputString[0];
                        inputString = inputString.Remove(0, 1);
                    }
                    else break;
                }

                return inputString + memString + "ay";
            }
        }
    }
}