using System;

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

            Console.Read();
        }
    }
}