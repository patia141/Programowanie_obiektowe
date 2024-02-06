using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolos
{
    public abstract class Ksztalt
    {
        public int X { get; set; }
        public int Y { get; set; }
        public abstract double Pole();
        public abstract double Obwod();
    }
}
