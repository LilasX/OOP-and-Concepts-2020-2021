using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawingApp.Entities
{
    public class Circle : Shape
    {
        protected int radius;
        
        public Circle(int radius, int x, int y,Color color) : base(x, y, color)
        {
            this.radius = radius;
        }
        public override void Draw(Graphics G)
        {
            int pointX = base.x - this.radius;
            int pointY = base.y - this.radius;
            int width  = 2 * this.radius;
            int height = 2 * this.radius;
            Rectangle myRectangle = new Rectangle(pointX, pointY, width, height);
            
            Pen myPen = new Pen(base.shape_color, 3);
            G.DrawEllipse(myPen, myRectangle);
        }

        public override double Get_Area()
        {
            return Math.PI * Math.Pow(this.radius , 2);
        }

        public override double Get_Perimeter()
        {
            return 2 * Math.PI * this.radius;
        }
    }
}
