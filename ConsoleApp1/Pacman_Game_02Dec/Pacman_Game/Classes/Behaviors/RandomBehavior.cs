using Pacman_Game.Classes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes.Behaviors
{
    public class RandomBehavior : IBehavior
    {
        private static RandomBehavior instance = null;
        private RandomBehavior() { }
        public static RandomBehavior Get_Instance()
        {
            return (instance == null) ? instance = new RandomBehavior() : instance;
            //return instance ??= new RandomBehavior();// available only C# 8.0
        }
        public void FindPath(Ghost ghost)
        {
            throw new NotImplementedException();
        }
    }
}
