using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomolyaN_nevekszurese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nevek = new List<string>();
            nevek.Add("Kiss István");
            nevek.Add("Nagy elemér");
            nevek.Add("kissándorjózsef23");
            nevek.Add(" Tóth# Ilona");
            nevek.Add("Homolya Nándor");

            while (true)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("0 Kilépés");
                Console.WriteLine("1 Néveleji szóközök levágva");
                Console.WriteLine("2 Csak nagybetűvel kezdődők");
                Console.WriteLine("3 Csak számjegy nélküliek");
                Console.WriteLine("4 Csak speciális jel nélküliek");
                Console.WriteLine("5 Legalább egy szóközt tartalmazók");
                Console.WriteLine("6 Csak rendes nevek");
                string valasz = Console.ReadLine();
                if (valasz == "0")
                {
                    return;
                }
                else if (valasz == "1")
                {

                }
                else if (valasz == "2")
                {

                }
                else if (valasz == "3")
                {

                }
                else if (valasz == "4")
                {

                }
                else if (valasz == "5")
                {

                }
                else if (valasz == "6")
                {

                }
                else
                {
                    Console.WriteLine("Nincs ilyen parancs");
                }
                Console.ReadKey();

            }
        }
    }
}
