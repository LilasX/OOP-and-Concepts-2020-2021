using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FinalProjectMaze.Classes.Entities
{
    public class EmptyTile : Tile
    {
        public EmptyTile (int row, int column) : base(row, column)
        {
            base.Entity_Color = Color.Green;
        }
    }
}
