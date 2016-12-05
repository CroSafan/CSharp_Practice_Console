using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop_Ordering_To_Go
{

    public class Bouquet
    {
        public List<Flower> flowers = new List<Flower>();

        public void AddFlowerToBouquet(Flower f1)
        {
            flowers.Add(f1);
        }

        public List<Flower> ReturnBouquet()
        {
            return flowers;
        }

        public float TotalPriceOfBouquet()
        {
            float total = 0;
            foreach (Flower f1 in flowers)
            {
                total += f1.Price;
            }
            return total;
        }


    }
}
