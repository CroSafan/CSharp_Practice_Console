using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge275_Splurthian_Chemistry_101
{
    class Program
    {
        /// <summary>
        /// https://www.reddit.com/r/dailyprogrammer/comments/4savyr/20160711_challenge_275_easy_splurthian_chemistry/
        /// </summary>
        /// <param name="args"></param>
        /// 

        public static bool IsSymbol(string element, string symbol)
        {
            bool isSymbol = false;
            if (symbol.Length < 2) isSymbol = false;
            int indexOfFirstChar = element.ToLower().IndexOf(symbol.ToLower()[0]);
            int indexOfSecondChar = element.ToLower().LastIndexOf(symbol.ToLower()[1]);

            if (indexOfFirstChar == -1 || indexOfSecondChar == -1) isSymbol = false;
            else if (indexOfFirstChar == indexOfSecondChar) isSymbol = true;
            else if (indexOfFirstChar < indexOfSecondChar) isSymbol = true;
            if (indexOfFirstChar == indexOfSecondChar && symbol.ToLower()[0] == symbol.ToLower()[1]) isSymbol = false;
            return isSymbol;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsSymbol("Spenglerium", "Ee"));
            Console.WriteLine(IsSymbol("Zeddemorium", "Zr"));
            Console.WriteLine(IsSymbol("Venkmine", "Kn"));
            Console.WriteLine(IsSymbol("Stantzon", "Zt"));
            Console.WriteLine(IsSymbol("Melintzum", "Nn"));
            Console.WriteLine(IsSymbol("Tullium", "Ty"));
            Console.Read();
        }
    }
}
