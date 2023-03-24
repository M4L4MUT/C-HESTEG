using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csomagolOOP
{
    internal class Dinnye
    {
        private int darab;
        private int atmero;
        private int anyag;
        private int sugar = this.atmero / 2;
        private int pi = 3.14; 

        public Dinnye() { }

        public void setDarab(int d) { this.darab = d }
        public void setAtmero(int a) { this.atmero = a }
        public void setSugar(int r) { this.sugar = r }
        public void setPI(int pi) { this.pi = pi }

        public void Szamol() 
        {
            this.anyag = this.darab * 4 * this.sugar * this.sugar * this.pi + 60;
        }

        public int getAnyag() { return this.anyag; }
    }
}
