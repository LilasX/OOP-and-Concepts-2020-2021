using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bouncing_Balls.ClassBallsFolder;

namespace Bouncing_Balls
{
    public partial class Form1 : Form
    {

        private List<Ball> myList;

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            Ball basket_ball = new Ball("Basket_ball.png", 0, 20, 100, 100);
            Ball soccer_ball = new Ball("Soccer_ball.png", 30, 0, 200, 200);
            Ball volley_ball = new Ball("Volley_ball.png", 30, 30, 300, 300);
            myList = new List<Ball>();
            myList.Add(basket_ball);
            myList.Add(soccer_ball);
            myList.Add(volley_ball);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < myList.Count; i++)
            {
                myList[i].Draw(e.Graphics);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Ball elements in myList)
            {
                elements.Move(this.Width, this.Height);
            }
            this.Refresh();
        }
        
    }
}
