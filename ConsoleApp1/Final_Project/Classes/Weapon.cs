using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Classes
{
    public class Weapon : Item
    {
        private int minDamage;
        private int maxDamage;

        public Weapon(string name, int price, int minDamage, int maxDamage):base(name, price)
        {
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
        }

        public Weapon()
        {
            this.minDamage = 0;
            this.maxDamage = 0;
        }

        public int MinDamage { get => minDamage; set => minDamage = value; }
        public int MaxDamage { get => maxDamage; set => maxDamage = value; }
    }
}
