using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mortage_Calculator
{
    class Program
    {
        public static double MjesecnaUplata(double zajam,double kamata,int godina)
        {
            double rata = (kamata / 100) / 12;
            double baza = (rata + 1);
            double mjesecno = godina * 12;
            double rez = 0;
            rez = zajam * (rata * (Math.Pow(baza, mjesecno)) / ((Math.Pow(baza, mjesecno)) - 1));

            return rez;
        }

        static void Main(string[] args)
        {
            double zajam = 0;
            double kamata = 0;
            double mjesecnaUplata = 0;
            double stanjeNaRacunu=0;
            int godina=0;
           

            Console.WriteLine("Upiši iznos zajma: ");
            zajam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Upiši iznos kamate: ");
            kamata = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Upiši broj godina zajma ");
            godina = Convert.ToInt16(Console.ReadLine());

            mjesecnaUplata = MjesecnaUplata(zajam, kamata, godina);
            stanjeNaRacunu = -(mjesecnaUplata * (godina * 12));
            Console.WriteLine(Math.Round(mjesecnaUplata));
            Console.WriteLine(Math.Round(stanjeNaRacunu));
            Console.Read();
        }
    }
}
