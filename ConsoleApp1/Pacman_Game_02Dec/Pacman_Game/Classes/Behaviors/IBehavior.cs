using Pacman_Game.Classes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes.Behaviors
{
    public interface IBehavior
    {
        //It should return List<Node>
        void FindPath(Ghost ghost);
    }
}
