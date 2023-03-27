using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbElem_03._27_
{
    internal class Szam
    {
        public int paros, paratlan, osszeg, szam;
        public Szam() { }

        public void setParos(int paros) { this.paros = paros; }
        public void setParatlan(int paratlan) { this.paratlan = paratlan; }
        public void setOsszeg(int osszeg) { this.osszeg = osszeg; }
        public void setSzam(int szam) { this.szam = szam; }
        public int getParatlan() { return this.paratlan; }
        public int getParos() { return this.paros; }

        public void Szamol() {
            for (this.osszeg = 0; this.osszeg <= 99;)
            {
                Console.WriteLine("Adjon meg egy számot.");
                this.szam = int.Parse(Console.ReadLine());
                if (this.szam % 2 == 0)
                {
                    this.paros++;
                }
                else { this.paratlan++; }
                this.osszeg = this.osszeg + this.szam;
                this.szam = 0;
            }
            Console.WriteLine("Összesen {0} páros, {1} páratlan számot adott meg.", this.paros, this.paratlan);
        }
    }
}

