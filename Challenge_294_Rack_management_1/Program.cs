using System;

namespace Challenge_294_Rack_management_1
{
    internal class Program
    {
        public static bool ScrabbleSolver(string scrambledInput, string input)
        {
            string storage = input;
            for (int i = 0; i < scrambledInput.Length; i++)
            {
                int index = storage.IndexOf(scrambledInput[i]);
                if (index == -1) continue;
                else storage = storage.Remove(index, 1);
            }
            if (storage.Length == 0) return true;
            else return false;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(ScrabbleSolver("ladilmy", "daily"));//true
            Console.WriteLine(ScrabbleSolver("eerriin", "eerie"));//false
            Console.WriteLine(ScrabbleSolver("orrpgma", "program"));//true
            Console.WriteLine(ScrabbleSolver("orpgma", "program"));//false
            Console.Read();
        }
    }
}