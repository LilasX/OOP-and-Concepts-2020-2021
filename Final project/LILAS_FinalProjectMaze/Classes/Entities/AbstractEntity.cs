using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FinalProjectMaze.Classes.Pathfinding;

namespace FinalProjectMaze.Classes.Entities
{
    public abstract class AbstractEntity
    {
        private int energy;
        private int row;
        private int column;
        private Color entity_Color;

        protected AbstractEntity(int energy, int row, int column)
        {
            this.energy = energy;
            this.column = column;
            this.row = row;
            this.entity_Color = Color.White;
        }

        public int Energy { get => energy; set => energy = value; }
        public int Column { get => column; set => column = value; }
        public int Row { get => row; set => row = value; }
        public Color Entity_Color { get => entity_Color; set => entity_Color = value; }

        public abstract void Draw(Graphics graphics);

        public void DrawBackground(Graphics graphics, Color backgroundColor, out int pointX, out int pointY)
        {
            pointX = this.Column * Map.Tile_size;
            pointY = this.Row * Map.Tile_size;
            int side = Map.Tile_size;
            Rectangle myRectangle = new Rectangle(pointX, pointY, side, side);
            Brush myBrush = new SolidBrush(backgroundColor);
            graphics.FillRectangle(myBrush, myRectangle);
            myBrush.Dispose();
        }
    }
}
