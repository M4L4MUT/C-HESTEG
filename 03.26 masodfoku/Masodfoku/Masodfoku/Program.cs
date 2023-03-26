using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masodfoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg az első számot.");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a második számot.");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a harmadik számot.");
            int c = int.Parse(Console.ReadLine());

            Masodfoku c1 = new Masodfoku();
            c1.setA(a);
            c1.setB(b);
            c1.setC(c);
            c1.Szamol();
            double e1 = c1.getEredmeny1();
            double e2 = c1.getEredmeny2();


            Console.WriteLine("Az első megoldás {0}, a második {1}",e1, e2);



            Console.ReadKey();
        }
    }
}
