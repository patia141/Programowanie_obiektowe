using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.shapes
{
    class Triangle: Shape
    {
        public void Draw()
        {
            Console.WriteLine($"Draw Triangle {X} {Y} {Width} {Height}");
        }
    }
}
