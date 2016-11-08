using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Between_Two_Cities
{
    class City
    {
       
        public Location locationOfCity { get; set; }

        public float DistanceBetweenCity(City city)
        {
            //Haversine formula
            //https://en.wikipedia.org/wiki/Haversine_formula
            //http://www.movable-type.co.uk/scripts/latlong.html
            float radiusOfEarth = 6731; //in km 
            float dLat = degToRadians(city.locationOfCity.xCord - this.locationOfCity.xCord);
            float dLon = degToRadians(city.locationOfCity.yCord - this.locationOfCity.yCord);
            float a = (float)(Math.Sin(dLat / 2) * Math.Sin(dLat / 2)
            + Math.Cos(degToRadians(this.locationOfCity.xCord)) * Math.Cos(degToRadians(city.locationOfCity.xCord)) *
            Math.Sin(dLon / 2) * Math.Sin(dLon / 2));

            float c = (float)(2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a)));
            float d = radiusOfEarth * c;
            return d;
        }
        public float degToRadians(float deg)
        {
            return deg * ((float)Math.PI / 180);
        }
    }
}
