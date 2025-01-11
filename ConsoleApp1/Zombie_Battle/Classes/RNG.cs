using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombie_Battle.Classes
{
    public class RNG
    {
        private static Random instance = null;
        private RNG() { }

        public static Random Get_Instance()
        {
            if(instance == null)
            {
                instance = new Random();
            }
            return instance;
        }
    }
}
