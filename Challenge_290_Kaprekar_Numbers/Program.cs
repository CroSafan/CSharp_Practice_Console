using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_290_Kaprekar_Numbers
{
    class Program
    {
        /// <summary>
        /// https://www.reddit.com/r/dailyprogrammer/comments/5aemnn/20161031_challenge_290_easy_kaprekar_numbers/
        /// </summary>
        /// <param name="args"></param>
        /// 

        static bool isKaprekarNumber(int input)
        {
            string squared = (input * input).ToString();
            if (Convert.ToInt32(squared) < 10) return false;
            int first = Convert.ToInt32(squared.Substring(0, squared.Length / 2));
            int second = Convert.ToInt32(squared.Substring(squared.Length / 2));
           
            if (first + second == input) return true;
            else return false;
        }
        static void Main(string[] args)
        {

            for (int i = 101; i <= 100; i++)
            {
                if (isKaprekarNumber(i)) Console.WriteLine(i);
            }
            for (int i = 2; i <= 9000; i++)
            {
                if (isKaprekarNumber(i)) Console.WriteLine(i);
            }

            Console.Read();
        }
    }
}
