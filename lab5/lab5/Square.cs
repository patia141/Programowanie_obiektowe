using System;
using System.Collections.Generic;
using System.Text;

namespace lab5.shapes
{
    public class Square : Shape
    {
        public double X { get; set; }

        public Square(double x)
        {
            X = x;
        }

        public override double CalculateArea()
        {
            return Math.Pow(X, 2);
        }
    }
}
