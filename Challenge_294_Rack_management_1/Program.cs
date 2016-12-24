using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Challenge_294_Rack_management_1
{
    internal class Program
    {
        public static bool ScrabbleSolver(string scrambledInput, string input)
        {
            int wildCardCount = 0;
            string storage = input;
            for (int i = 0; i < scrambledInput.Length; i++)
            {
                if (scrambledInput[i] == '?')
                {
                    wildCardCount++;
                }
                else
                {
                    int index = storage.IndexOf(scrambledInput[i]);
                    if (index == -1) continue;
                    else storage = storage.Remove(index, 1);
                }

            }
            if (storage.Length == 0 || storage.Length == wildCardCount) return true;
            else return false;
        }
        public static string LongestScrabbleWord(string input)
        {
            List<string> matchinWords = new List<string>();

            StreamReader sr = new StreamReader(@"C:\Users\Antun\Documents\Visual Studio 2015\Projects\CSharp_Practice_Console\Challenge_294_Rack_management_1\enable1.txt");
            while (!sr.EndOfStream)
            {
                if (!ScrabbleSolver(input, sr.ReadLine())) matchinWords.Add(sr.ReadLine());
            }

            matchinWords.OrderBy(x => x.Length).ToArray();
            return matchinWords[0];
        }


        private static void Main(string[] args)
        {
            Console.WriteLine(ScrabbleSolver("ladilmy", "daily"));//true
            Console.WriteLine(ScrabbleSolver("eerriin", "eerie"));//false
            Console.WriteLine(ScrabbleSolver("orrpgma", "program"));//true
            Console.WriteLine(ScrabbleSolver("orpgma", "program"));//false
            Console.WriteLine(ScrabbleSolver("pizza??", "pizzazz"));//true
            Console.WriteLine(ScrabbleSolver("piizza?", "pizzazz"));//false            
            Console.WriteLine(ScrabbleSolver("a??????", "program"));//true
            Console.WriteLine(ScrabbleSolver("b??????", "program"));//false
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine(LongestScrabbleWord("dcthoyueorza"));
            Console.WriteLine(LongestScrabbleWord("uruqrnytrois"));
            Console.WriteLine(LongestScrabbleWord("rryqeiaegicgeo??"));
            Console.WriteLine(LongestScrabbleWord("udosjanyuiuebr??"));
            Console.WriteLine(LongestScrabbleWord("vaakojeaietg????????"));
            Console.Read();
        }
    }
}