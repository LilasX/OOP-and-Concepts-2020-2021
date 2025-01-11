using Pacman_Game.Classes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes.Behaviors
{
    public class FollowBehavior : IBehavior
    {
        private static FollowBehavior instance = null;
        private FollowBehavior() { }
        public static FollowBehavior Get_Instance()
        {
            return (instance == null) ? instance = new FollowBehavior() : instance;
            //return instance ??= new FollowBehavior();// available only C# 8.0
        }
        public void FindPath(Ghost ghost)
        {
            throw new NotImplementedException();
        }
    }
}
