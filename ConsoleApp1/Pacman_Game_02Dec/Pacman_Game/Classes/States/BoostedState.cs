using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes.States
{
    public class BoostedState : IState
    {
        private static BoostedState instance = null;
        private BoostedState() { }

        public static BoostedState GetInstance()
        {
            if(instance == null)
            {
                instance = new BoostedState();
            }
            return instance;
        }


        public bool CanEatGhost()
        {
            return true;
        }
    }
}
