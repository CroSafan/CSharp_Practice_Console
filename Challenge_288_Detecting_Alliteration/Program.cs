using System;
using System.Collections.Generic;
using System.IO;

namespace Challenge_288_Detecting_Alliteration
{
    internal class Program
    {
        /// <summary>
        /// https://www.reddit.com/r/dailyprogrammer/comments/57zcbm/20161017_challenge_288_easy_detecting_alliteration/
        /// </summary>
        /// <param name="args"></param>
        /// 
        public static void RemoveStopWords(string input)
        {
            var split = input.Split(' ');
            bool stop = false;

            for (int i = 0; i < split.Length; i++)
            {
                stop = false;
                for (int j = 0; j < stopWords.Length; j++)
                {
                    if (split[i].ToLower() == stopWords[j].ToLower()) stop = true;

                }
                if (!stop) Console.WriteLine(split[i]);
            }

        }

        public static string[] stopWords = new string[] {
                "I","a","about","an","and","are","as",
                "at","be","by","com","for","from","how",
                "in","is","it","of","on","or","that",
                "the","this","to","was","what","when",
                "where","who","will","with","the"};
        private static void Main(string[] args)
        {

            string[] input = File.ReadAllLines(@"C:\Users\Antun\Documents\Visual Studio 2015\Projects\CSharp_Practice_Console\Challenge_288_Detecting_Alliteration\input.txt");
            for (int i = 0; i < input.Length; i++)
            {
                RemoveStopWords(input[i]);
            }
            Console.Read();
        }
    }
}