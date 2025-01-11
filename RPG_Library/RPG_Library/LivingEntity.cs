using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Library
{
    public abstract class LivingEntity : IEntity
    {
        private string name;
        private int hp;

        protected LivingEntity(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }

        protected LivingEntity()
        {
            this.name = null;
            this.hp = 0;
        }

        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }



        public bool IsDead()
        {
            return this.Hp <= 0;
        }

        public virtual void Receive_Damage(int damage)
        {
            this.Hp -= damage;
            Console.WriteLine("Your enemy got hit ! The current HP of your enemy = " + this.Hp);
        }

        public abstract void Attack();

        public override string ToString()
        {
            return this.Name + " " + this.Hp;
        }
    }
}
