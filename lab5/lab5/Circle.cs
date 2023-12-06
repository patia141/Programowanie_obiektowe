using System;
using System.Collections.Generic;
using System.Text;

namespace lab5.shapes
{
    class Circle: Shape
    {
        public double R { get; set; }

        public Circle(double r)
        {
            R = r;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(R, 2); 
        }
    }
}
