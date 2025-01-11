using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Library
{
    public class Monster : LivingEntity
    {
        private int ap;
        private int rxp;
        private Player target;

        public Monster(string name, int hp, int ap, int rxp) : base(name, hp)
        {
            this.ap = ap;
            this.rxp = rxp;
        }

        public Monster()
        {
            this.ap = 0;
            this.rxp = 0;
            this.target = null;
        }

        public int Ap { get => ap; set => ap = value; }
        public int Rxp { get => rxp; set => rxp = value; }
        public Player Target { get => target; set => target = value; }

        public override void Attack()
        {
            Console.WriteLine("\nThe enemy is attacking you");
            int random_damage = Dice.Get_Instance().Next(0, this.Ap);
            this.target.Receive_Damage(random_damage);
        }
    }
}
