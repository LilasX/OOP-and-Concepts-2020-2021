using Pacman_Game.Classes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes.Behaviors
{
    public class ChaseBehavior : IBehavior
    {
        private static ChaseBehavior instance = null;
        private ChaseBehavior() { }
        public static ChaseBehavior Get_Instance() 
        { 
            return (instance == null) ? instance = new ChaseBehavior() : instance;
            //return instance ??= new ChaseBehavior();// available only C# 8.0
        }
        public void FindPath(Ghost ghost)
        {
            throw new NotImplementedException();
        }
    }
}
