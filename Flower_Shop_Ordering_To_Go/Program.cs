using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop_Ordering_To_Go
{
    /// <summary>
    /// Flower Shop Ordering To Go - 
    /// Create a flower shop application which deals in
    /// flower objects and use those flower objects in a
    /// bouquet object which can then be sold. 
    /// Keep track of the number of objects
    /// and when you may need to order more.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Flower f1 = new Flower("Rose", 22.2f);
            Flower f2 = new Flower("Lily", 22.2f);
            Flower f3 = new Flower("Violet", 22.2f);
            Flower f4 = new Flower("Lotus", 22.2f);

            Bouquet b1 = new Bouquet();
            b1.AddFlowerToBouquet(f1);
            b1.AddFlowerToBouquet(f2);
            b1.AddFlowerToBouquet(f3);
            b1.AddFlowerToBouquet(f4);

            Bouquet b2 = new Bouquet();
            b2.AddFlowerToBouquet(f1);
            b2.AddFlowerToBouquet(f2);
            b2.AddFlowerToBouquet(f3);
            b2.AddFlowerToBouquet(f4);

            Bouquet b3 = new Bouquet();
            b3.AddFlowerToBouquet(f1);
            b3.AddFlowerToBouquet(f2);
            b3.AddFlowerToBouquet(f3);
            b3.AddFlowerToBouquet(f4);

            Store s1 = new Store();
            s1.storage.Add(b1);
            s1.storage.Add(b2);
            s1.storage.Add(b3);

            Console.WriteLine(s1.TotalMoneyInStore());

            s1.SellBouqet(b3);
            s1.SellBouqet(b1);

            Console.WriteLine(s1.TotalMoneyInStore());

            Console.WriteLine(s1.ReturnProfit());

            Console.Read();

        }
    }
}
