using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challeng_291Goldilocks_Bear_Necessities
{
    class Program
    {
        /// <summary>
        /// https://www.reddit.com/r/dailyprogrammer/comments/5bn0b7/20161107_challenge_291_easy_goldilocks_bear/
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            string[] input = File.ReadAllLines(@"C:\Users\Antun\Documents\Visual Studio 2015\Projects\CSharp_Practice_Console\Challeng_291Goldilocks_Bear_Necessities\input.txt");
            int weightMin = Convert.ToInt32(input[0].Split(' ')[0]);
            int temperatureMax = Convert.ToInt32(input[0].Split(' ')[1]);
            List<string> numberOfCorrectSeats = new List<string>();
            for (int i = 1; i < input.Length; i++)
            {
                int chairWeightCapacity = Convert.ToInt32(input[i].Split(' ')[0]);
                int temperatureOfPorridge = Convert.ToInt32(input[i].Split(' ')[1]);
                if (chairWeightCapacity > weightMin && temperatureMax >temperatureOfPorridge)
                    numberOfCorrectSeats.Add(i.ToString());
            }
            foreach (var item in numberOfCorrectSeats) Console.WriteLine(item);
            Console.Read();
        }
    }
}
