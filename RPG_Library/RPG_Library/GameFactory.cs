using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Library
{
    public static class GameFactory
    {
        public static Monster CreateMonster()
        {
            int random = Dice.Get_Instance().Next(0, 100);

            if (random <= 10)
            {
                return new Dragon("Dragon", 120, 40, 3);
            }
            else
            if (random > 10 && random <= 40)
            {
                return new Monster("Ogre", 80, 20, 2);
            }

            return new Monster("Goblin", 40, 10, 1);
        }
        public static Power CreateHealing()
        {
            return new Power("Magic Potion", 200, Power_Type.Healing, 2);
        }
        public static Power CreateInvisible()
        {
            return new Power("Magic Cape", 300, Power_Type.Invisible, 3);
        }
        public static Power CreateProtect()
        {
            return new Power("Wood Shield", 100, Power_Type.Protect, 1);
        }
        public static Power CreateSleepy()
        {
            return new Power("Sleepy Dust", 600, Power_Type.Sleepy, 6);
        }
        public static Weapon CreateRock()
        {
            return new Weapon("Big rock", 100, 20, 30);
        }
        public static Weapon CreateTorch()
        {
            return new Weapon("Torch", 300, 35, 45);
        }
        public static Weapon CreateSword()
        {
            return new Weapon("Magic Sword", 500, 50, 60);
        }
        public static Weapon CreateStick()
        {
            return new Weapon("Wood Stick", 0, 5, 15);
        }
    }
}
