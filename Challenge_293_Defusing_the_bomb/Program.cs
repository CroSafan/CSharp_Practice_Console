using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_293_Defusing_the_bomb
{
    class Program
    {
        /// <summary>
        /// https://www.reddit.com/r/dailyprogrammer/comments/5e4mde/20161121_challenge_293_easy_defusing_the_bomb/
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool defused = false;
            int numberOfWiresDefused = 0;
            var wires = File.ReadAllLines(@"C:\Users\Antun\Documents\Visual Studio 2015\Projects\CSharp_Practice_Console\Challenge_293_Defusing_the_bomb\input.txt");
            for (int i = 0; i < wires.Length; i++)
            {
                if (i == wires.Length - 1)
                {
                    numberOfWiresDefused++;
                }
                else
                {
                    switch (wires[i])
                    {
                        case "white":
                            if (wires[i + 1] != "black" || wires[i + 1] != "white") numberOfWiresDefused++;
                            break;
                        case "red":
                            if (wires[i + 1] == "green") numberOfWiresDefused++;
                            break;
                        case "black":
                            if (wires[i + 1] != "white" || wires[i + 1] != "green" || wires[i + 1] != "orange") numberOfWiresDefused++;
                            break;
                        case "orange":
                            if (wires[i + 1] == "red" || wires[i + 1] == "black") numberOfWiresDefused++;
                            break;
                        case "green":
                            if (wires[i + 1] == "orange" || wires[i + 1] == "white") numberOfWiresDefused++;
                            break;
                        case "purple":
                            if (wires[i + 1] != "purple" || wires[i + 1] != "green" || wires[i + 1] != "orange" || wires[i + 1] != "white") numberOfWiresDefused++;
                            break;
                    }
                }

            }
            if (numberOfWiresDefused == wires.Length) defused = true;

            Console.WriteLine(defused ? "Defused" : "Boom");
            Console.Read();
        }
    }
}
