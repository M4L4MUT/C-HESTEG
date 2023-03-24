using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csempezesOOP_14._
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a terület szélességét méterben:");
                int szelesseg =  int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg a terület magasságát méterben:");
                int magassag = int.Parse(Console.ReadLine());

            Csempe c1 = new Csempe();
            c1.setMagassag(magassag);
            c1.setSzelesseg(szelesseg);
            c1.Szamol();
            double csempe = c1.getCsempe();
            Console.WriteLine("A terület becsempézéséhez {0} db csempére lesz szükség.", csempe);
            Console.ReadKey();
        }
    }
}
