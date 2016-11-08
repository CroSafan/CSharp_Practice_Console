using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Between_Two_Cities
{
    class Program
    {
        static void Main(string[] args)
        {
            City city1 = new City();
            City city2 = new City();
            city1.locationOfCity.xCord = 50.0359f;
            city1.locationOfCity.yCord= 005.4253f;
            city2.locationOfCity.xCord = 58.3838f;
            city2.locationOfCity.yCord = 003.0412f;
            // it works
            //TODO fix the rounding up, a little bit of on the exact distance;
            Console.WriteLine(city1.DistanceBetweenCity(city2));
            Console.Read();
        }
    }
}
