using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zalinf
{
    public abstract class Ksztalt
    {
        // Hermetyzacja
        private int x;
        public int X 
        {
            get 
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        private int y;
        public int Y 
        {
            get 
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        // Metody abstrakcyjne, które muszą być zaimplementowane w klasach dziedziczących
        public abstract float ObliczPole();
        public abstract float ObliczObwod();

    }
}
