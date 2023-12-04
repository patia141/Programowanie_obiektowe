using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.shapes
{
    class Circle: Shape
    {
        public void Draw()
        {
            Console.WriteLine($"Draw Circle {X} {Y} {Width} {Height}");
        }
    }
}
