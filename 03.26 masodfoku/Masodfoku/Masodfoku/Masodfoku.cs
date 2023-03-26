using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masodfoku
{
    internal class Masodfoku
    {

        private double a, b, c, eredmeny1, eredmeny2, gyok;

        public Masodfoku() { }

        public void setA(double a) { this.a = a; }
        public void setB(double b) { this.b = b; }
        public void setC(double c) { this.c = c; }
        public double getEredmeny1() { return this.eredmeny1; }
        public double getEredmeny2() { return this.eredmeny2; }

        public void Szamol()
        {
            this.eredmeny1 = (-this.b + Math.Sqrt((this.b * this.b) - (4 * this.a * this.c))) / (2 * this.a);
            this.eredmeny2 = (-this.b - Math.Sqrt((this.b * this.b) - (4 * this.a * this.c))) / (2 * this.a);
        }
    }
}
