using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapeDrawingApp.Entities;

namespace ShapeDrawingApp
{
    public partial class Form1 : Form
    {
        Shape myShape;
        Shape rectangle;

        public Form1()
        {
            InitializeComponent();
            myShape = new Circle(100, 200, 200, Color.BlueViolet);
            rectangle = new ShapeRectangle(300, 200, 600, 200, Color.Aqua);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            myShape.Draw(e.Graphics);
            rectangle.Draw(e.Graphics);
        }
    }
}
