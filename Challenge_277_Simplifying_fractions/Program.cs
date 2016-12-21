using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_277_Simplifying_fractions
{
    class Program
    {
        /// <summary>
        /// https://www.reddit.com/r/dailyprogrammer/comments/4uhqdb/20160725_challenge_277_easy_simplifying_fractions/
        /// </summary>
        /// <param name="args"></param>
        /// 

        public static void SimplifyFraction(int a, int b)
        {
            var highestCommonDivisor = 1;
            for (int i = 2; i <= a; i++)
            {
                if (b % i == 0)
                {
                    if (a % i == 0)
                    {
                        highestCommonDivisor = i;
                    }
                }
            }

            Console.WriteLine("{0}|{1}", a / highestCommonDivisor, b / highestCommonDivisor);
        }

        static void Main(string[] args)
        {
            SimplifyFraction(4 ,8);
            SimplifyFraction(1536, 78360);
            SimplifyFraction(51478, 5536);
            SimplifyFraction(46410, 119340);
            SimplifyFraction(7673, 4729);
            SimplifyFraction(4096, 1024);
            Console.Read();

        }
    }
}
