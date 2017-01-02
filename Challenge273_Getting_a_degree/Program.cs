using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge273_Getting_a_degree
{
    class Program
    {
        /// <summary>
        /// https://www.reddit.com/r/dailyprogrammer/comments/4q35ip/20160627_challenge_273_easy_getting_a_degree/
        /// </summary>
        /// <param name="args"></param>
        /// 
        public static float CelsiusToFahrenheti(float number)
        {
            return (float)(number * 1.8) + 32;
        }

        public static float FahrenHeitToCelsius(float number)
        {
            return (float)((number - 32) / 1.8);
        }
        public static double RadiansToDeg(double number)
        {
            return number * (180 / Math.PI);
        }
        public static double DegToRadians(double number)
        {
            return (number * Math.PI) / 180;
        }

        public static double KelvinToCelsius(double number)
        {
            return number - 273.15;
        }


        public static void ConvertInput(string input)
        {
            string conversion = input.Substring(input.Length - 2);
            double numberToConvert = Convert.ToDouble(input.Substring(0, input.Length - 2).Replace('.', ','));
            switch (conversion)
            {
                case "dr":
                    Console.WriteLine("{0}r", Math.Round(DegToRadians(numberToConvert), 2));
                    break;
                case "rd":
                    Console.WriteLine("{0}d", Math.Round(RadiansToDeg(numberToConvert), 2));
                    break;
                case "cf":
                    Console.WriteLine("{0}f", CelsiusToFahrenheti((float)numberToConvert));
                    break;
                case "kc":
                    Console.WriteLine("{0}c", KelvinToCelsius(numberToConvert));
                    break;
                case "fc":
                    Console.WriteLine("{0}c", FahrenHeitToCelsius((float)numberToConvert));
                    break;
                default:
                    Console.WriteLine("No candidate for conversion");
                    break;
            }



        }
        static void Main(string[] args)
        {
            ConvertInput("3.1416rd");
            ConvertInput("90dr");
            Console.WriteLine("------");
            ConvertInput("212fc");
            ConvertInput("70cf");
            ConvertInput("100cr");
            ConvertInput("315.15kc");

            Console.Read();
        }
    }
}
