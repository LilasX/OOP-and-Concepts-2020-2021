using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Classes
{
    public class Dragon : Monster
    {
        private int rgp;

        public Dragon(string name, int hp, int ap, int rxp) : base(name, hp, ap, rxp)
        {
            this.rgp = Dice.Get_Instance().Next(1000, 10000);
        }

        public Dragon()
        {
            this.rgp = 0;
        }

        public int Rgp { get => rgp; set => rgp = value; }
    }
}
