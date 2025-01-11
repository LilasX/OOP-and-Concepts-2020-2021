using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombie_Battle.Classes
{
    public class Zombie
    {
        private string name;
        private int hp; //Health Points
        private int atk; //Attack Power
        private Zombie target;

        public Zombie(string name, int hp, int atk)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
            this.target = null;
        }

        public Zombie Target { get => target; set => target = value; }

        /*
         public void Set_Target(Zombie value)
        {
            this.target = value;
        }

        public Zombie Get_Target()
        {
            return this.target;
        }
        */

        public bool Is_Dead()
        {
            /* 
            Beginner method
             
            if (this.hp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            */

            /*
            Shorter version

            return (this.hp <= 0) ? true : false;
            */

            return this.hp <= 0; //Optimal version
        }

        public void Take_Damage(int damage)
        {
            //this.hp = this.hp - damage;
            this.hp -= damage;
            Console.WriteLine("Zombie " + name + " is hit ! His current HP = " + this.hp);
            if(this.Is_Dead()) //this.Is_Dead() == true
            {
                Console.WriteLine("Zombie " + name + " is dead !");
            }
        }

        public void Attack()
        {
            Console.WriteLine("Zombie " + name + " is attacking his target ...");
            if (this.Target != null)
            {
                //To do : Take a random Damage
                int damage = RNG.Get_Instance().Next(this.atk); //random between 0...atk-1

                this.Target.Take_Damage(damage);
            }
            
        }

    }
}
