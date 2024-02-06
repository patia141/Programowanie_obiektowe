using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolos
{
    public class Kolo : Ksztalt
    {
        public int R { get; set; }
        public override double Pole()
        {
            return Math.PI*R*R;
        }
        public override double Obwod()
        {
            return 2*Math.PI*R;
        }
    }
}
