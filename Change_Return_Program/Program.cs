using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Return_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfItem;
            double moneyGiven;

            Console.WriteLine("Type in how much money you gave:");
            moneyGiven = Convert.ToDouble(Console.ReadLine());            
            Console.WriteLine("Type in how much money your item costs:");
            priceOfItem = Convert.ToDouble(Console.ReadLine());
            //double change = moneyGiven - priceOfItem;
            //double returnMoney =  change - Math.Floor(change);
            double returnMoney = moneyGiven - priceOfItem;
            double change =Math.Round( (Math.Round(returnMoney,2) - Math.Floor(returnMoney)),2);
            int numOfQuarters = 0;
            int numOfDimes = 0;
            int numOfNickels = 0;
            int numOfPennys = 0;
            
            
           Console.WriteLine(returnMoney);
            Console.WriteLine(change);
            while (change != 0)
            {
                if (change > 0.25D )
                {
                    numOfQuarters++;
                    change -= 0.25D;
                 
                }
                else if (change >0.1D )
                {
                    
                    numOfDimes++;
                    change -= 0.10D;
                    
                }
                else if (change > 0.05D)
                {
                    numOfNickels++;
                    change -= 0.05D;
                   
                }
                else if (change >0.01D)
                {
                    numOfPennys++;
                    //can't figure out why it doesn't round up
                    //change =Math.Round(change,2)-0.01D;
                    //temporary fix- sort of 
                    change = 0;
                    
                }
            }
            Console.WriteLine("Number of quarters:{0}", numOfQuarters);
            Console.WriteLine("Number of dimes:{0}", numOfDimes);
            Console.WriteLine("Number of nickels:{0}", numOfNickels);
            Console.WriteLine("Number of pennys:{0}", numOfPennys);

            Console.ReadLine();

        }
    }
}
