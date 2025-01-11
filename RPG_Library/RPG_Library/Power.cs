using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Library
{
    public class Power : Item
    {
        private Power_Type type;
        private int minXp;

        public Power(string name, int price, Power_Type type, int minXp) : base(name, price)
        {
            this.type = 0;
            this.minXp = 0;
        }

        public Power()
        {

        }

        public Power_Type Type { get => type; set => type = value; }
        public int MinXp { get => minXp; set => minXp = value; }
    }
}
