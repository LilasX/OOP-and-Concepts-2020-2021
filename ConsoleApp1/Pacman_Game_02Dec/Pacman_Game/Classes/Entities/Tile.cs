using System;
using System.Drawing;
using Pacman_Game.Classes.Pathfinding;

namespace Pacman_Game.Classes.Entities
{
    public class Tile: AbstractEntity
    {
        public Tile(int row, int column):base(0, row, column)
        {
        }
        public sealed override void Draw(Graphics graphics)
        {
            int pointX, pointY;
            base.DrawBackground(graphics, base.Entity_Color, out pointX, out pointY);
        }
    }
}
