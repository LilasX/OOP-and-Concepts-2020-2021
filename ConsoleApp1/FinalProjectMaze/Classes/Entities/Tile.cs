using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FinalProjectMaze.Classes.Entities
{
    public class Tile : AbstractEntity
    {
        public Tile (int row, int column) : base (row, column)    { }

        public sealed override void Draw(Graphics graphics)
        {
            int pointX, pointY;
            base.DrawBackground(graphics, base.Entity_Color, out pointX, out pointY);
        }
    }
}
