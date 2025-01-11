using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Classes
{
    public class Monster : LivingEntity
    {
        private int ap;
        private int rxp;
        private Player target;

        public Monster() : base()
        {
          
        }

        public Monster(string name, int hp, int ap, int rxp): base(name, hp)
        {
            this.Ap = ap;
            this.Rxp = rxp;
            this.Target = null;
        }

        public int Ap { get => ap; set => ap = value; }
        public int Rxp { get => rxp; set => rxp = value; }
        public Player Target { get => target; set => target = value; }

        public override void Attack()
        {
            int random_damage = Dice.GetInstance().Next(0, this.Ap);
            this.Target.ReceiveDamage(random_damage);
        }
    }
}
