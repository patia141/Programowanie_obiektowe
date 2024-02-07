using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zalinf
{
    public class Trojkat : Ksztalt
    {
        private int a;
        private int h;
        
        // Konstruktor
        public Trojkat(int a, int h)
        {
            this.a = a;
            this.h = h;
        }

        // Nadpisanie metod abstrakcyjnych
        public override float ObliczObwod()
        {
            int obwod = 3 * a;
            return obwod;
        }

        public override float ObliczPole()
        {
            int pole = (a * h) / 2;
            return pole;
        }
    }
}
