using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraPercMp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, q, x, y;
            Console.WriteLine("Add meg az  első órát: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az  első percet: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg az  első másodpercet: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a második órát : ");
            q = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a második percet : ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a második másodpercet: ");
            y = int.Parse(Console.ReadLine());
            MP c1 = new MP();
            c1.setA(a);
            c1.setB(b);
            c1.setC(c);
            c1.setD();
            c1.setQ(q);
            c1.setX(x);
            c1.setY(y);
            c1.setZ();
            c1.setEredmeny();
            Console.ReadKey();
        }
    }
}
