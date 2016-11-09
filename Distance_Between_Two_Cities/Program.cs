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
            city1.locationOfCity.xCord = 36.12;
            city1.locationOfCity.yCord= -86.67;
            city2.locationOfCity.xCord = 33.94;
            city2.locationOfCity.yCord = -118.40;
            // it works
            
            Console.WriteLine(city1.DistanceBetweenCity(city2));
            Console.Read();
        }
    }
   

}
