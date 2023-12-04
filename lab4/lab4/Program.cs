using System;
using System.Collections.Generic;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();

            var shape1 = new Rectangle() {
                X = 5, 
                Width = 2
            };

            shape1.Height = 3;

            //shapes.Add();

            shapes.Add(new Circle()
            {
                X = 5,
                Width = 7
            });

            shapes.Add(new Rectangle()
            {
                X = 7,
                Width = 2
            });

            shapes.Add(new Triangle()
            {
                X = 4,
                Width = 6
            });

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            for (int i=0; i < shapes.Count; i++)
            {
                shapes[i].Draw();
            }
        }
    }
}
