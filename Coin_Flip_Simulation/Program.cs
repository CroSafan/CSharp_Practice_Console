using System;
using System.Threading;

namespace Coin_Flip_Simulation
{
    internal class Program
    {
        private static int numHeads = 0;
        private static int numTails = 0;

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of coin flips");
            int numberOfRepeats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numberOfRepeats);
            for (int i = 0; i < numberOfRepeats; i++)
            {
                Thread.Sleep(10);
                CoinFlip();
            }

            Console.WriteLine("Number of heads: {0}", numHeads);
            Console.WriteLine("Number of tails: {0}", numTails);
            Console.ReadLine();
        }

        public static Random r = new Random();

        public static void CoinFlip()
        {
            int chosenOne = r.Next(0, 2);
            if (chosenOne == 1)
            {
                Console.WriteLine("Heads");
                numHeads++;
            }
            else
            {
                Console.WriteLine("Tails");
                numTails++;
            }
        }
    }
}