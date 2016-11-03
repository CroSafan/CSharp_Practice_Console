using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_Of_Tiles
{
    class Program
    {
        /// <summary>
        /// Find Cost of Tile to Cover W x H Floor - 
        /// Calculate the total cost of tile it would take 
        /// to cover a floor plan of width and height, using a
        /// cost entered by the user.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double dimension,x,y,cost;

            Console.WriteLine("Enter the dimensions of the room");
            dimension = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the dimensions of the x for one tile");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the dimensionsof the y for one tile");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the cost of a tile");
            cost = Convert.ToDouble(Console.ReadLine());
            double totalCost = ((dimension / (x * y)) * cost);
            Console.WriteLine("The total cost of tiles: {0}", totalCost);

            Console.Read();

        }
    }
}
