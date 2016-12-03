using System;
using System.Collections.Generic;

namespace Sieve_of_Eratosthenes
{
    class Program
    {
        /// <summary>
        /// Sieve of Eratosthenes - 
        /// The sieve of Eratosthenes is one of the most
        /// efficient ways to find all of the smaller primes
        /// (below 10 million or so).
        /// </summary>
        /// <param name="args"></param>
        /// http://stackoverflow.com/questions/25702173/c-sharp-sieve-of-eratosthenes
        static void Main(string[] args)
        {
            Sieve(10000);
            Console.Read();
        }


        public static void Sieve(int n)
        {
            HashSet<int> NoPrime = new HashSet<int>();

            for (int x = 2; x < n; x++)
            {
                for (int y = x * 2; y < n; y = y + x)
                {
                    if (!NoPrime.Contains(y))
                    {
                        NoPrime.Add(y);
                    }
                }
            }

            for (int z = 2; z < n; z++)
            {
                if (!NoPrime.Contains(z))
                {
                    Console.WriteLine(z);
                }
            }
        }





    }
}

