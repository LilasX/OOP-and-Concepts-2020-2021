using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_06_23.Class_2020_06_30
{
    class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
             foreach(var shape in shapes) //enhanced loop - fashion loop (dara)
            {
                switch (shape.Type)
                {
                    case ShapeType.Circle:
                        Console.WriteLine("Draw a circle");
                        break;

                    case ShapeType.Rectangle:
                        Console.WriteLine("Draw a rectangle");
                        break;

                    case ShapeType.Triangle:
                        Console.WriteLine("Draw a triangle");
                        break;
                }
            }
        }
    }
}
