using System;

namespace Count_Vowels
{
    internal class Program
    {
        /// <summary>
        /// Count Vowels - Enter a string and the program counts the number of vowels in the text.
        /// For added complexity have it report a sum of each vowel found.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int[] vowelCount = new int[5];

            string senternce = Console.ReadLine();
            for (int i = 0; i < senternce.Length; i++)
            {
                for (int j = 0; j < vowelCount.Length; j++)
                    if (senternce.ToLower()[i] == vowels[j])
                    {
                        vowelCount[j]++;
                    }
            }

            Console.WriteLine("Number of the letter A:{0}", vowelCount[0]);
            Console.WriteLine("Number of the letter E:{0}", vowelCount[1]);
            Console.WriteLine("Number of the letter I:{0}", vowelCount[2]);
            Console.WriteLine("Number of the letter O:{0}", vowelCount[3]);
            Console.WriteLine("Number of the letter U:{0}", vowelCount[4]);
            Console.Read();
        }
    }
}