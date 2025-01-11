using Pacman_Game.Classes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes.Behaviors
{
    public class ScaredBehavior : IBehavior
    {
        private static ScaredBehavior instance = null;
        private ScaredBehavior() { }
        public static ScaredBehavior Get_Instance()
        {
            return (instance == null) ? instance = new ScaredBehavior() : instance;
            //return instance ??= new ScaredBehavior();// available only C# 8.0
        }
        public void FindPath(Ghost ghost)
        {
            throw new NotImplementedException();
        }
    }
}
