using System;

namespace Unit_Converter
{
    internal class Program
    {
        /// <summary>
        /// Unit Converter (temp, currency, volume, mass and more)
        /// - Converts various units between one another.
        /// The user enters the type of unit being entered,
        /// the type of unit they want to convert to and then the value.
        /// The program will then make the conversion.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.WriteLine(CelsiusToFahrenheti(20));
        }

        public static float CelsiusToFahrenheti(float number)
        {
            return (float)(number * 1.8) + 32;
        }

        public static float FahrenHeitToCelsius(float number)
        {
            return (float)((number - 32) / 1.8);
        }

        public static float KunaToDollar(float money)
        {
            return money * 0.15f;
        }

        public static float DollarToKuna(float money)
        {
            return money * 6.81f;
        }
    }
}