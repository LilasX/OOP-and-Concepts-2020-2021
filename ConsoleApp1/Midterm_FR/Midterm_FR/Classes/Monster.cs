using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_FR.classes
{
    public abstract class Monster : IMonster
    {
        private string name;
        private int ap;
        private int hp;
        private readonly int hp_max;

        public Monster(string name, int ap, int hp)
        {
            this.name = name;
            this.ap = ap;
            this.hp = hp;
            this.hp_max = hp;
        }

        public string Name { get => name; set => name = value; }
        public int Ap { get => ap; set => ap = value; }
        public int Hp { get => hp; set => hp = value; }
       

        public int Hp_max => hp_max;

        public abstract void Attack(Monster target);

        public virtual void ReceiveDamage(int damage)
        {
            this.hp -= damage;
        }
    }
}
