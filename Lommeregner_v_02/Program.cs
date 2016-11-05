using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner_v_02
{
    class Program
    {
        // Lavet ef Rolf 05-11-2016
        static void Main(string[] args)
        {
            var lommeMaskine = new Lommeregner();
            bool forfra = true;
            do
            {
                lommeMaskine.Grafik();
                lommeMaskine.Tallet1();

                lommeMaskine.Tallet2();
                lommeMaskine.Beregner();
                Console.WriteLine("Hvis du vil afslutte programmet! tryk q eller Q og enter");
                Console.WriteLine("For at fortsætte tryk på en vilkårlig tast! ");
                var quit = Console.ReadLine();
                if (quit == "q" || quit == "Q")
                {
                    forfra = false;
                }

            } while (forfra);
            
            

        }

        

    }
}
