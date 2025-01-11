using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_FR.classes
{
    public class Pokemon : Monster
    {
        private int speed;
        private Energy type;
        private State currentState;

        public Pokemon(string name, int ap, int hp, int speed, Energy type) : base (name, ap, hp)
        {
            this.speed = speed;
            this.type = type;
            this.currentState = State.Innactive;
        }

        public int Speed { get => speed; set => speed = value; }
        public Energy Type { get => type; set => type = value; }
        public State CurrentState { get => currentState; set => currentState = value; }

        public override void ReceiveDamage(int damage)
        {
            this.Hp -= damage;
            if(Hp <= 0)
            {
                this.currentState = State.Innactive;
            }
        }
        //----------------------------------------------------------------------------
        public override void Attack(Monster target)
        {
            if(this.currentState == State.Active)
            {
                target.ReceiveDamage(Ap);
            }
            else if(this.currentState == State.Innactive)
            {
                Console.WriteLine("I'm not active yet.");
            }
         }
         //----------------------------------------------------------------------------
         public bool IsKnockout()
         {
            if(Hp <= 0)
            {
                this.currentState = State.Innactive;
                return true;
            }
            else
            {
                return false;
            }
         }
         //----------------------------------------------------------------------------
         public void Heal()
         {
            this.Hp = this.Hp_max;
         }
         //------------------------------------------------------------------------------
         
         public override string ToString()
         {
             return this.Name+" , HP: "+this.Hp+" , AP: "+this.Ap+" , Speed: "+this.speed+", State: "+this.currentState+ ", Energy Type: " + this.type;
         }
        }
    }
