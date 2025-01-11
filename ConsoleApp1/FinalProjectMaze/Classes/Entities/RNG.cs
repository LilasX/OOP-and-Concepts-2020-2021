using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectMaze.Classes.Entities
{
    public class RNG : Random
    {
        //Singleton
        private static RNG instance = null;

        private RNG() : base(){}

        public static RNG Get_Instance()
        {
            if (instance == null)
            {
                instance = new RNG();
            }
            return instance;
        }
    }
}
