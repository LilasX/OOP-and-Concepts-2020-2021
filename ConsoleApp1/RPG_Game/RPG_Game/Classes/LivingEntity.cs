using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Classes
{
    public abstract class LivingEntity
    {
        private string name;
        private int hp;

        protected LivingEntity()
        {
            this.Name = "";
            this.Hp = 0;
        }

        protected LivingEntity(string name, int hp)
        {
            this.Name = name;
            this.Hp = hp;
        }

        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }

        public bool IsDead()
        {
            return this.hp <= 0;
        }

        public virtual void ReceiveDamage(int damage)
        {
            this.hp -= damage;
        }

        public abstract void Attack();
    }
}
