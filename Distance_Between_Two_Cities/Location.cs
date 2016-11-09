using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_Between_Two_Cities
{
    class Location
    {
        //latitude and longitude
        public double xCord { get; set; }
        public double yCord { get; set; }
        public Location(double x ,double y)
        {
            this.xCord = x;
            this.yCord = y;
        }
        public Location()
        {

        }
    }
}
