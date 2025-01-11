using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Library
{
    public class Player : LivingEntity
    {
        private int xp;
        private int gp;
        //private readonly int hp_max;
        private bool protect;
        private Monster enemy;
        private List<Power> my_powers;
        private Weapon my_weapon;

        public Player(string name, int hp, int xp, int gp) : base(name, hp)
        {
            //this.hp_max = hp;
            this.xp = 0;
            this.gp = 0;
            this.protect = false;
            this.enemy = null;
            this.my_powers = new List<Power>();
            this.my_weapon = GameFactory.CreateStick();
        }

        public Player() : base()
        {

        }

        public int Xp { get => xp; set => xp = value; }
        public int Gp { get => gp; set => gp = value; }
        public bool Protect { get => protect; set => protect = value; }
        public Monster Enemy { get => enemy; set => enemy = value; }
        public List<Power> My_powers { get => my_powers; set => my_powers = value; }
        public Weapon My_weapon { get => my_weapon; set => my_weapon = value; }
        //public int Hp_max => hp_max;

        public void Heal()
        {
            Console.WriteLine("Your HP has been restored ! ");
            //this.Hp = Hp_max;
            this.Hp = 100;
        }

        public void Hide()
        {
            Console.WriteLine("You are hidden ! You ran away ! ");
            this.enemy = null;
        }

        public void Sprinkle()
        {
            Console.WriteLine("The enemy is now asleep");

            Dragon EDragon = enemy as Dragon;
            if (this.enemy == EDragon)
            {
                Console.WriteLine("You stole " + EDragon.Rgp + " from the dragon");
                this.gp += EDragon.Rgp;
                this.Hide();
            }
            else
            {
                Hide();
            }
        }

        public void Add(Power p)
        {
            this.My_powers.Add(p);
        }

        public Power Get_Power(Power_Type type)
        {
            for (int i = 0; i < this.My_powers.Count; i++)
            {
                Power obj = this.My_powers[i];
                if (obj.Type == type)
                {
                    this.My_powers.RemoveAt(i);
                    return obj;
                }
            }
            return null;
        }

        public void Apply_Power(Power_Type type)
        {
            Power obj_power = this.Get_Power(type);

            if (obj_power != null)
            {
                if (this.Xp >= obj_power.MinXp)
                {
                    switch (type)
                    {
                        case Power_Type.Healing:
                            this.Heal();
                            break;

                        case Power_Type.Invisible:
                            this.Hide();
                            break;

                        case Power_Type.Protect:
                            this.Protect = true;
                            break;

                        case Power_Type.Sleepy:
                            this.Sprinkle();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Type of power nonexistent. ");
                }
            }

        }

        public override void Receive_Damage(int damage)
        {
            if (this.Protect)
            {
                this.Hp -= damage / 2;
            }
            else
            {
                this.Hp -= damage;
            }
            Console.WriteLine("You have been hit ! Your current HP = " + this.Hp);
        }

        public void BuyItem(Item newItem)
        {
            if (this.Gp >= newItem.Price)
            {
                this.gp -= newItem.Price;
            }
            if (newItem is Weapon aWeapon)
            {
                if (this.My_weapon.MaxDamage < aWeapon.MaxDamage)
                {
                    this.my_weapon = aWeapon;
                }
            }
            else if (newItem is Power newPower)
            {
                Add(newPower);
            }
        }

        public void Update_Weapon(Weapon new_weapon)
        {
            if (this.My_weapon.MaxDamage < new_weapon.MaxDamage)
            {
                this.My_weapon = new_weapon;
            }
        }

        public override void Attack()
        {
            Console.WriteLine("You're attacking the enemy " + this.Enemy.Name);

            int min_damage = this.My_weapon.MinDamage;
            int max_damage = this.My_weapon.MaxDamage;

            int damage = Dice.Get_Instance().Next(min_damage, max_damage + 1);
            this.Enemy.Receive_Damage(damage);

            if (this.enemy.IsDead())
            {
                Dragon EDragon = enemy as Dragon;
                this.Xp += Enemy.Rxp;
                if (this.Enemy == EDragon)
                {
                    Console.WriteLine("You killed the dragon and looted " + EDragon.Rgp + " gold");
                    this.Gp += EDragon.Rgp;
                }
            }
        }

        public int CountPower(Power_Type type)
        {
            int counter = 0;

            foreach (Power obj in this.my_powers)
            {
                if (obj.Type == type)
                {
                    counter++;
                }
            }
            return counter;
        }

        public override string ToString()
        {
            string str = "Player : HP = " + base.Hp + " | XP = " + this.xp + " | GP = " + this.gp + "\n";
            str += "Weapon : " + my_weapon.Name + "\n";
            str += "Powers : Protect = " + CountPower(Power_Type.Protect);
            str += " | Invisible = " + CountPower(Power_Type.Invisible);
            str += " | Healing  = " + CountPower(Power_Type.Healing);
            str += " | Sleepy  = " + CountPower(Power_Type.Sleepy);

            return str;
        }
    }
}
