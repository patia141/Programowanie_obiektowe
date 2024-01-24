using System;
using System.Collections.Generic;
using System.Text;

namespace zadania_przed_kolosem
{
    abstract class Ksztalt
    {
        public abstract double Pole { get; }
        public abstract double Obwod { get; }
    }

    class Prostokąt : Ksztalt
    {
        public double Dlugosc { get; set; }
        public double Szerokosc { get; set; }

        public override double Pole => Dlugosc * Szerokosc;
        public override double Obwod => 2 * (Dlugosc + Szerokosc);
    }

    class Trójkąt : Ksztalt
    {
        public double BokA { get; set; }
        public double BokB { get; set; }
        public double BokC { get; set; }

        public override double Pole
        {
            get
            {
                double p = (BokA + BokB + BokC) / 2;
                return Math.Sqrt(p * (p - BokA) * (p - BokB) * (p - BokC));
            }
        }

        public override double Obwod => BokA + BokB + BokC;
    }

    class Koło : Ksztalt
    {
        public double Promien { get; set; }

        public override double Pole => Math.PI * Math.Pow(Promien, 2);
        public override double Obwod => 2 * Math.PI * Promien;
    }
}
