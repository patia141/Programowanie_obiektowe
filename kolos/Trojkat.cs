using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolos
{
    public class Trojkat : Ksztalt
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public override double Pole()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public override double Obwod()
        {
            return A+B+C;
        }
    }
}
