using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_F2020_7243.Classes
{
    public class Ghost : Entity
    {
        private bool visible;

        public Ghost(int row, int column) : base (row, column)
        {
            this.visible = true;
        }

        public bool Visible { get => visible; set => visible = value; }

        public void Hide()
        {
            Visible = false;
        }

        public void Show()
        {
            Visible = true;
        }

        
        public Image image = Image.FromFile(Maze.path + "boo.jpg");
                
        public override void Draw(Graphics g)
        {
            if (this.Visible)
            {
                int size = Maze.cellSize;
                Rectangle bounds = new Rectangle(this.Column * size, this.Row * size, size, size);
                g.DrawImage(image, bounds);
            }
        }
    }
}
