using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawingApp.Entities
{
    public abstract class Shape: IShape2D
    {
        protected int x;
        protected int y;
        protected Color shape_color;

        protected Shape(int x, int y, Color shape_color)
        {
            this.x = x;
            this.y = y;
            this.shape_color = shape_color;
        }
        public abstract void Draw(Graphics G);

        //Interface IShape2D
        public abstract double Get_Area();
        public abstract double Get_Perimeter();
    }
}
