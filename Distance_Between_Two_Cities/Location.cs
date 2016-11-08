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
        public float xCord { get; set; }
        public float yCord { get; set; }
        public Location(float x ,float y)
        {
            this.xCord = x;
            this.yCord = y;
        }
        public Location()
        {

        }
    }
}
