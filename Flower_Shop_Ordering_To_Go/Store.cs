using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower_Shop_Ordering_To_Go
{
    public class Store
    {
        public List<Bouquet> storage = new List<Bouquet>();
        public static float profit = 0;

        public Store()
        {

        }

        public float TotalMoneyInStore()
        {
            float total = 0;
            foreach (Bouquet b1 in storage)
            {
                total += b1.TotalPriceOfBouquet();
            }
            return total;
        }

        public void SellBouqet(Bouquet b1)
        {
            profit += b1.TotalPriceOfBouquet();
            storage.Remove(b1);
        }

        public float ReturnProfit()
        {
            return profit;
        }
    }
}
