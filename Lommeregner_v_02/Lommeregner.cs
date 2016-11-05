using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Microsoft.Win32.SafeHandles;

namespace Lommeregner_v_02
{
    class Lommeregner
    {
        public double tal1;
        public double tal2;
        public double total;
        private string valg;
        private double plus;
        private double minus;
        private double gange;
        private double dividere;


        public double Tallet1()
        {

            try
            {
                Console.WriteLine("Indtast det første tal: ");
                
                var fraBruger = Console.ReadLine();
                var result = double.TryParse(fraBruger, out tal1);
                if (result)
                {
                    return tal1;
                }
                
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed. ");
            }
            return tal1;
        }

        public double Tallet2()
        {
            try
            {
                Console.WriteLine("Indtast det andet tal: ");
                
                var frabruger = Console.ReadLine();
                var result = double.TryParse(frabruger, out tal2);
                if (result)
                {
                    return tal2;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed. ");
            }
            return tal2;
        }

        
        public void Beregner()
        {
           
            plus = tal1 + tal2;
            minus = tal1 - tal2;
            dividere = tal1/tal2;
            gange = tal1*tal2;
             
            Console.WriteLine("Resultatet for plus = : " + plus);
            Console.WriteLine("Resultatet for minus = : " + minus);
            Console.WriteLine("Resultatet for dividere = : " + dividere);
            Console.WriteLine("Resultatet for gange = : " + gange);

        }

        public void Grafik()

        {
            string name = "***   Lommeregner v 02   ***";
            Console.WriteLine("****************************");
            Console.WriteLine(name.ToUpper());
            Console.WriteLine("****************************");
            Console.WriteLine("");
            
        }

        
    }
}
