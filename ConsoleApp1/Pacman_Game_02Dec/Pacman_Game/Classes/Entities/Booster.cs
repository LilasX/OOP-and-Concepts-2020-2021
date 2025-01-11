using System;
using System.Drawing;
using Pacman_Game.Classes.Pathfinding;

namespace Pacman_Game.Classes.Entities
{
    public class Booster : AbstractEntity
    {
        public Booster(int row, int column) : base(50, row, column)
        {
           
        }

        public override void Draw(Graphics graphics)
        {
            //Drawing the background
            int pointX, pointY;
            base.DrawBackground(graphics, Color.Black, out pointX, out pointY);

            //Drawing the Booster
            int boosterPointX = pointX + (Map.Tile_size / 4);
            int boosterPointY = pointY + (Map.Tile_size / 4);
            int boosterSide = Map.Tile_size / 2;
            Rectangle boosterRectangle = new Rectangle(boosterPointX, boosterPointY, boosterSide, boosterSide);
            Brush boosterBrush = new SolidBrush(base.Entity_Color);
            graphics.FillEllipse(boosterBrush, boosterRectangle);
            boosterBrush.Dispose();
        }
    }
}
