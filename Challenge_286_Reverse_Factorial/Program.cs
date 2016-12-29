using System;

namespace Challenge_286_Reverse_Factorial
{
    internal class Program
    {
        public static void ReverseFactorial(int number)
        {
            int counter = 2;
            while (counter < number)
            {
                number /= counter;
                counter++;
            }
            if (number % counter == 0) Console.WriteLine("{0}!", counter);
            else Console.WriteLine("None");
        }

        /// <summary>
        /// https://www.reddit.com/r/dailyprogrammer/comments/55nior/20161003_challenge_286_easy_reverse_factorial/
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            ReverseFactorial(120);
            ReverseFactorial(150);
            ReverseFactorial(3628800);
            ReverseFactorial(479001600);
            ReverseFactorial(6);
            ReverseFactorial(18);
            Console.Read();
        }
    }
}