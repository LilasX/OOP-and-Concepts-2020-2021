using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleDelegate
{
    public class Rectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public double CalculateArea()
        {
            double area = this.Width * this.Height;
            Console.WriteLine("Rectangle Area = "+ area);
            return area;
        }
        public double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            Console.WriteLine("Rectangle Perimeter = "+ perimeter);
            return perimeter;
        }
    }
}
