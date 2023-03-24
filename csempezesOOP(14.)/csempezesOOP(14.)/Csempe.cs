using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csempezesOOP_14._
{
    internal class Csempe
    {
        public int szelesseg;
        public int magassag;
        public double csempe;
        public Csempe() { }
        
        public void setSzelesseg(int sz) { this.szelesseg= sz; }
        public void setMagassag(int m) { this.magassag= m; }

        public void Szamol()
        {
            this.csempe = (this.magassag * 100 * this.magassag * 100) / (20 * 20) * 1.1;
            if (this.csempe % 1 !=0)
            {
                this.csempe = this.csempe - this.csempe % 1 + 1;
            }
        }

        

        public double getCsempe() { return this.csempe; }
    }
}
