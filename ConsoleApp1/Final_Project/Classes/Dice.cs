using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Classes
{
    public class Dice : Random
    {
        private static Dice instance = null;
        private Dice() : base() { }

        public static Dice Get_Instance()
        {
            if (instance == null)
            {
                instance = new Dice();
            }
            return instance;
        }
    }
}
