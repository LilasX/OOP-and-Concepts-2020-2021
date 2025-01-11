using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LabTrafficLight.Classes
{
    public class Car
    {
        private int speed;
        private Point location;
        private int width;
        private int height;
        private string image;
        public static string path = "../../images/";

        public int Speed { get => speed; set => speed = value; }

        public Car()
        {
            this.speed = 0;
            this.location = new Point(0,300); //0,400
            this.width = 233;
            this.height = 91;
            this.image = "CAR.png";
        }

        public Car(int locationY)
        {
            this.speed = 0;
            this.location = new Point(0, locationY); //0,400
            this.width = 233;
            this.height = 91;
            this.image = "CAR.png";
        }

        public Car(string image, Point location, int width, int height)
        {
            this.speed = 0;
            this.location = location;
            this.width = width;
            this.height = height;
            this.image = image;
        }

        public void Brake()
        {
            this.speed = 0;
        }

        public void Start(int speed)
        {
            this.speed = speed;
        }

        public void Slowdown()
        {
            this.speed = this.speed/2;
        }

       

        public void Draw(Graphics graphics)
        {
            Image myImage = Image.FromFile(path + this.image);
            Rectangle myRectangle = new Rectangle(this.location.X, this.location.Y, this.width, this.height);
            graphics.DrawImage(myImage, myRectangle);
        }

        public void Move()
        {
            this.location.X += this.speed;
        }

    }
}
