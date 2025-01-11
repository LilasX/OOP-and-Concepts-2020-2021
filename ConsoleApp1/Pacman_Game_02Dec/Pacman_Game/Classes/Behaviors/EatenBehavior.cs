using Pacman_Game.Classes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes.Behaviors
{
    public class EatenBehavior : IBehavior
    {
        private static EatenBehavior instance = null;
        private EatenBehavior() { }
        public static EatenBehavior Get_Instance()
        {
            return (instance == null) ? instance = new EatenBehavior() : instance;
            //return instance ??= new EatenBehavior();// available only C# 8.0
        }
        public void FindPath(Ghost ghost)
        {
            throw new NotImplementedException();
        }
    }
}
