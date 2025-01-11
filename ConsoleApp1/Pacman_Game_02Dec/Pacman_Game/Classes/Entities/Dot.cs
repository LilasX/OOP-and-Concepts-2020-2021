using System;
using System.Drawing;
using Pacman_Game.Classes.Pathfinding;

namespace Pacman_Game.Classes.Entities
{
    public class Dot: AbstractEntity
    {
        public Dot(int row , int column):base(10, row, column)
        {
            
        }
        public override void Draw(Graphics graphics)
        {
            int pointX, pointY;
            base.DrawBackground(graphics,Color.Black, out pointX, out pointY);

            //Drawing the Dot
            int dotPointX = pointX + (Map.Tile_size * 2 / 5);
            int dotPointY = pointY + (Map.Tile_size * 2 / 5);
            int dotSide = Map.Tile_size / 5;
            Rectangle dotRectangle = new Rectangle(dotPointX, dotPointY, dotSide, dotSide);
            Brush dotBrush = new SolidBrush(base.Entity_Color);
            graphics.FillEllipse(dotBrush, dotRectangle);
            dotBrush.Dispose();

        }

        
    }
}
