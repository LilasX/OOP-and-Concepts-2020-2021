using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Classes
{
    public class Player : LivingEntity
    {
        private int xp;
        private int gp;
        private readonly int max_hp;
        private bool protect;
        private Monster enemy;
        private Weapon myWeapon;
        private List<Power> myPowers;

        public int Xp { get => xp; set => xp = value; }
        public int Gp { get => gp; set => gp = value; }

        public int Max_hp => max_hp;

        public bool Protect { get => protect; set => protect = value; }
        public Monster Enemy { get => enemy; set => enemy = value; }
        public Weapon MyWeapon { get => myWeapon; set => myWeapon = value; }
        public List<Power> MyPowers { get => myPowers; set => myPowers = value; }

        public Player() : base()
        {
            
        }

        public Player(string name, int hp) : base(name,hp)
        {
            this.xp = 0;
            this.gp = 0;
            this.max_hp = hp;
            this.protect = false;
            this.enemy = null;
            this.myWeapon = GameFactory.CreateStick();
            this.myPowers = new List<Power>();
        }

        public void Heal()
        {
            this.Hp = this.Max_hp;
        }

        public void Hide()
        {
            this.enemy = null;
        }

        public void Sprinkle()
        {
            if(this.enemy is Dragon)
            {
                this.gp += (this.enemy as Dragon).Rgp;
            }
            this.Hide();
        }

        public void AddPower(Power power)
        {
            this.myPowers.Add(power);
        }

        public Power GetPower(PowerType type)
        {
            
            foreach(Power p in this.myPowers)
            {
                if(p.Type == type)
                {
                    return p;
                }
            }

            return null;
        }

        public void ApplyPower(PowerType type)
        {
            Power objPower = this.GetPower(type);
            if(objPower != null)
            {
                if(this.xp >= objPower.Min_XP)
                {
                    switch (type)
                    {
                        case PowerType.Healing: Heal();
                                break;
                        case PowerType.Invisible: Hide();
                                break;
                        case PowerType.Protect: this.protect = true;
                            break;
                        case PowerType.Sleepy: Sprinkle();
                            break;
                    }
                    this.myPowers.Remove(objPower);
                }
                else
                {
                    Console.WriteLine("You don't have enough experience to use that power type!");
                }
            }
            else
            {
                Console.WriteLine("You don't have that power type!");
            }
        }

        public void UpdateWeapon(Weapon weapon)
        {
            if(weapon.Max_Damage > this.myWeapon.Max_Damage)
            {
                this.myWeapon = weapon;
            }
        }

        public void BuyItem(Item item)
        {
            if(this.gp >= item.Price)
            {
                this.gp -= item.Price;
                if(item is Weapon)
                {
                    this.UpdateWeapon(item as Weapon);
                }
                else if(item is Power)
                {
                    this.AddPower(item as Power);
                }
            }
            else
            {
                Console.WriteLine("You don't have enough GP to buy this item!");
            }
        }

        public override void ReceiveDamage(int damage)
        {
            if (this.protect)
            {
                base.ReceiveDamage(damage / 2);
            }
            base.ReceiveDamage(damage);
        }

        public override void Attack()
        {
            int random_damage = Dice.GetInstance().Next(this.myWeapon.Min_Damage, this.myWeapon.Max_Damage);
            this.enemy.ReceiveDamage(random_damage);
            if (this.enemy.IsDead())
            {
                this.xp += this.enemy.Rxp;
                if(this.enemy is Dragon)
                {
                    this.gp += (this.enemy as Dragon).Rgp;
                }
            }
        }

        //------------------------------------------------------------------------
        public int CountPower(PowerType type)
        {
            int counter = 0;

            foreach (Power obj in this.MyPowers)
            {
                if (obj.Type == type)
                {
                    counter++;
                }
            }
            return counter;
        }       
        //------------------------------------------------------------------------------
        public override string ToString()
        {
            string str = "Player : HP = " + base.Hp + " | XP = " + this.Xp + " | GP = " + this.Gp+"\n";
            str += "Weapon : " + myWeapon.Name +"\n" ;
            str += "Powers : Protect = " + CountPower(PowerType.Protect);
            str += " | Invisible = " + CountPower(PowerType.Invisible);
            str += " | Healing  = " + CountPower(PowerType.Healing);
            str += " | Sleepy  = " + CountPower(PowerType.Sleepy);

            return str;
        }
        
    }
}
