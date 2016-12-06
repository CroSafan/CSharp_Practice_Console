using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Get_IP_Adress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your IP adress is{0}", GetIPAdress());

            Console.Read();
        }



        private static string GetIPAdress()
        {

            using (WebClient client = new WebClient())
            {
                try
                {
                    return client.DownloadString("http://wtfismyip.com/text");
                }
                catch (Exception)
                {

                    return "Couldn't rettrieve your IP adress";
                }
            }


        }
    }
}
