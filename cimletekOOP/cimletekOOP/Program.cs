using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace CimletekOOP
{
    internal class Cimlet
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Adja meg az összeget Forintban:");
            int osszeg = int.Parse(Console.ReadLine());
           
            Cimletek c1 = new Cimletek();
            c1.setOsszeg(osszeg);
            c1.Szamol();
            int[,] t = c1.getCimletek();
            
            for (int i = 0;i < t.GetLength(0); i++)
            {
                if (t[i, 1] != 0)
                Console.WriteLine("{0} címletből {1} db kell", t[i, 0],t[i, 1]);
            }
            Console.ReadKey();
        }+
    }
}