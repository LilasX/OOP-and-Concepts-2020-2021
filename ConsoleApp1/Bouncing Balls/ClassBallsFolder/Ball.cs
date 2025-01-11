using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace Bouncing_Balls.ClassBallsFolder
{
    public class Ball
    {
        private int radius;
        private Point center;
        private string image;
        private Point velocity;
        public string path = "../../imagesballs/";

        public Ball (string image, int vx, int vy, int center_x, int center_y)
        {
            this.radius = 50;
            this.velocity = new Point(vx, vy);
            this.center = new Point(center_x, center_y);
            this.image = image;
        }

        public void Draw(Graphics g)
        {
            using (Image myImage = Image.FromFile(path + this.image))
            {
                int x = this.center.X - this.radius;
                int y = this.center.Y - this.radius;
                int width = 2 * this.radius;
                int height = 2 * this.radius;
                Rectangle myRectangle = new Rectangle(x, y, width, height);
                g.DrawImage(myImage, myRectangle);
            }
            
        }

        public void Move(int MaxX, int MaxY)
        {
            bool IsBouncing = false;

            if(this.center.X+radius >= MaxX || this.center.X-radius <=0)
            {
                this.velocity.X = -this.velocity.X;
                IsBouncing = true;
            }
            if(this.center.Y+radius >= MaxY || this.center.Y+radius <= 0)
            {
                this.velocity.Y = -this.velocity.Y;
                IsBouncing = true;
            }

            if (IsBouncing == true)
            {
                this.Boing();
            }
            this.center.X += this.velocity.X;
            this.center.Y += this.velocity.Y;
        }

        public void Boing()
        {
            using (SoundPlayer player = new SoundPlayer(path + "boing.wav"))
            {
                player.Play();
            }
        }

    }
}
