using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolos
{
    public class Prostokat : Ksztalt
    {
        public int A { get; set; }
        public int B { get; set; }
        public override double Pole()
        {
            return A * B;
        }

        public override double Obwod()
        {
            return 2 * (A + B);
        }
    }
}
