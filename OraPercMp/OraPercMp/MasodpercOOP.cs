using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraPercMp
{
    internal class MP
    {
        public int a, b, c, d, q, x, y, z, eredmeny;
        public MP() { }
        public MP(int a, int b, int c, int d, int q, int x, int y, int z, int eredmeny)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.q = q;
            this.x = x;
            this.y = y;
            this.z = z;
            this.eredmeny = eredmeny;
        }

        public void setA(int a)
        {
            this.a = a;
        }
        public void setB(int b)
        {
            this.b = b;
        }
        public void setC(int c)
        {
            this.c = c;
        }
        public void setD()
        {
            this.d = this.a * 3600 + this.b * 60 + this.c;
        }
        public void setQ(int q)
        {
            this.q = q;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public void setZ()
        {
            this.z = this.q * 3600 + this.x * 60 + this.y;
        }
        public void setEredmeny()
        {
            if (this.d > this.z)
            {
                this.eredmeny = this.d - this.z;
                Console.WriteLine("A két időpont között eltelt {0} másodperc",this.eredmeny);
            }
            else
            {
                this.eredmeny = this.z - this.d;
                Console.WriteLine("A két időpont között eltelt {0} másodperc", this.eredmeny);
            }
        }
    }
}
