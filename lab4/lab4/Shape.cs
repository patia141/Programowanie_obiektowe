using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.shapes
{
    class Shape
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Shape");
        }

    }
}
