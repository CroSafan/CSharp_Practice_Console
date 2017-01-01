using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_274_Gold_and_Treasure_The_Beale__Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText(@"C:\Users\Antun\Documents\Visual Studio 2015\Projects\CSharp_Practice_Console\Challenge_274_Gold and Treasure_The_Beale _Cipher\input.txt").Split(',').Select(int.Parse).ToList();
            var declaration = File.ReadAllText(@"C:\Users\Antun\Documents\Visual Studio 2015\Projects\CSharp_Practice_Console\Challenge_274_Gold and Treasure_The_Beale _Cipher\declaration.txt");

            foreach (var item in input)
            {
                string output = "";
                if (item > 1322) output= declaration.Split(' ')[1322-item - 1];
                else
                output = declaration.Split(' ')[item - 1];
                Console.Write(output[0]);
            }

            Console.Read();
        }
    }
}
