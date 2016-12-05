using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop_Ordering_To_Go
{
    public class Flower
    {
        public string Type { get; set; }
        public float Price { get; set; }

        public Flower(string type, float price)
        {
            Type = type;
            Price = price;
        }


    }
}
