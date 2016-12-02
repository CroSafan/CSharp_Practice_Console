using System;

namespace Collatz_Conjecture
{
    class Program
    {
        /// <summary>
        /// Collatz Conjecture - Start with a number n > 1. 
        /// Find the number of steps it takes to reach one using the following process: 
        /// If n is even, divide it by 2. If n is odd, multiply it by 3 and add 1.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int stepCounter = 1;

            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 1)
            {
                Console.WriteLine("The number you entered needs to be greater than 1");
            }
            else
            {
                while (n > 1)
                {
                    if (n % 2 == 0)
                    {
                        n /= 2;
                    }
                    else
                    {
                        n = n * 3 + 1;
                    }
                    stepCounter++;
                }
                Console.WriteLine("Number of steps to reach 1: {0}", stepCounter);
            }
            Console.Read();
        }
    }
}
