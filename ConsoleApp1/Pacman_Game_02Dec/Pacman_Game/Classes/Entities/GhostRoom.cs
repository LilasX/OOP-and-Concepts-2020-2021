using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacman_Game.Classes.Pathfinding;

namespace Pacman_Game.Classes.Entities
{
    public class GhostRoom: Tile
    {
        public GhostRoom(int row, int column) :base(row, column)
        {
            base.Entity_Color = Color.Black;
        }
        
    }
}
