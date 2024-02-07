using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zalinf
{
    public class Kolo : Ksztalt
    {
        private int r;

        // Konstruktor
        public Kolo(int r)
        {
            this.r = r;
        }

        // Nadpisanie metod abstrakcyjnych
        public override float ObliczObwod()
        {
            // Wykorzystanie rzutowania typu
            float obwod = (float)(2 * Math.PI * r);
            return obwod;
        }

        public override float ObliczPole()
        {
            // Wykorzystanie rzutowania typu
            float pole = (float)(Math.PI * r * r);
            return pole;
        }
    }
}
