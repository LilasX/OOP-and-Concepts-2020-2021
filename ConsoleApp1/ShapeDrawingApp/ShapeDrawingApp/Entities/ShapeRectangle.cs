using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDrawingApp.Entities
{
    class ShapeRectangle : Shape
    {
        private int width;
        private int height;

        public ShapeRectangle(int width, int height, int x, int y, Color shape_color) : base(x, y, shape_color)
        {
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics G)
        {
            int pointX = base.x - width / 2;
            int pointY = base.y - height / 2;
            Rectangle myRectangle = new Rectangle(pointX, pointY, width, height);

            Pen myPen = new Pen(base.shape_color, 3);
            G.DrawRectangle(myPen, myRectangle);
        }

        public override double Get_Area()
        {
            return this.width * this.height;
        }

        public override double Get_Perimeter()
        {
            return 2 * width + 2 * height;
        }

    }
}
