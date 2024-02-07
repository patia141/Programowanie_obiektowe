using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zalinf
{
    public class Prostokat : Ksztalt
    {
        // Konstruktor używający właściwości z klasy bazowej
        public Prostokat(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Nadpisanie metod abstrakcyjnych
        public override float ObliczObwod()
        {
            int obwod = 2 * X + 2 * Y;
            return obwod;
        }

        public override float ObliczPole()
        {
            int pole = X * Y;
            return  pole;
        }
    }
}
