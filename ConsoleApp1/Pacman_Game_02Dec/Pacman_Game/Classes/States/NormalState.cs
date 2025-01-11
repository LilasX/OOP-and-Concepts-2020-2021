using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes.States
{
    public class NormalState : IState
    {
        private static NormalState instance = null;
        private NormalState() { }

        public static NormalState GetInstance()
        {
            if(instance == null)
            {
                instance = new NormalState();
            }
            return instance;
        }

        public bool CanEatGhost()
        {
            return false;
        }
    }
}
