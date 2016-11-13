using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Vowels
{
    class Program
    {
        /// <summary>
        /// Count Vowels - Enter a string and the program counts the number of vowels in the text. 
        /// For added complexity have it report a sum of each vowel found.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int vowelCount = 0;
            string senternce = Console.ReadLine();
            for (int i = 0; i < senternce.Length; i++)
            {
                if(senternce[i]=='A' || senternce[i] == 'E' || senternce[i] == 'I' || senternce[i] == 'O' ||senternce[i] == 'U')
                {
                    vowelCount++;
                }
            }

            Console.WriteLine(vowelCount);

        }
    }
}
