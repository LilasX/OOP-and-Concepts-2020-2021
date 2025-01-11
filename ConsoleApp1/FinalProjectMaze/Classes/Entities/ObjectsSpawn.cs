using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectMaze.Classes.Entities
{
    public class ObjectsSpawn : Tile
    {
        public ObjectsSpawn(int row, int column) : base(row, column)
        {
            base.Entity_Color = Color.Green;
        }
    }
}
