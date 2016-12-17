using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge295_Letter_by_letter
{
    class Program
    {
        static void Main(string[] args)
        {

            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            char[] nekaj = word1.ToCharArray();
            char[] nekaj2 = word2.ToCharArray();
            for (int i = 0; i < word1.Length; i++)
            {
                nekaj[i] = nekaj2[i];
                Console.WriteLine(nekaj[i]);
            }
        }
    }
}
