using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Words
{
    class Program
    {
        /// <summary>
        /// Count Words in a String - 
        /// Counts the number of individual words in a string. 
        /// For added complexity read these strings
        /// in from a text file and generate a summary.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int brojac = 0;
            string word = Console.ReadLine();
            string[] placeholder = word.Split(' ');
            for(int i = 0; i < placeholder.Count(); i++)
            {
                Console.WriteLine(placeholder[i]);
            }
            brojac = placeholder.Length;
            Console.WriteLine(brojac);
            Console.Read();
        }
    }
}
