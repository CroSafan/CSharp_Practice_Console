using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Between_Two_Cities
{
    class City
    {

        public Location locationOfCity=new Location();

        public double DistanceBetweenCity(City city)
        {
            //Haversine formula
            //https://en.wikipedia.org/wiki/Haversine_formula
            //http://www.movable-type.co.uk/scripts/latlong.html
            double radiusOfEarth = 6372.8; //in km 
            //lat = x coord
            double dLat = degToRadians(city.locationOfCity.xCord - this.locationOfCity.xCord);
            //lon = y coord
            double dLon = degToRadians(city.locationOfCity.yCord - this.locationOfCity.yCord);

            this.locationOfCity.xCord = degToRadians(this.locationOfCity.xCord);
            city.locationOfCity.xCord = degToRadians(city.locationOfCity.xCord);

            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(this.locationOfCity.xCord) * Math.Cos(city.locationOfCity.xCord);
            var c = 2 * Math.Asin(Math.Sqrt(a));
            return radiusOfEarth * 2 * Math.Asin(Math.Sqrt(a));
            
        }
        public double degToRadians(double deg)
        {
            return deg * (Math.PI / 180);
        }
    }
}
