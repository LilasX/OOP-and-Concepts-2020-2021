using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zombie_Battle.Classes;

namespace Zombie_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            Zombie obj1 = new Zombie("Steve", 100, 20);
            Zombie obj2 = new Zombie("Ghost", 120, 18);

            Battle(obj1, obj2);

            Console.ReadKey();
        }

        static void Battle(Zombie zombie1, Zombie zombie2)
        {
            zombie1.Target = zombie2;
            //zombie1.Set_Target(zombie2);
            zombie2.Target = zombie1;
            //zombie2.Set_Target(zombie1);

            //To do : Random first attacker
            Random random = RNG.Get_Instance();
            double turn = random.NextDouble(); //return number between 0.0 and 0.99
            //Zombie current_attacker = zombie1;
            Zombie current_attacker = (turn <= 0.5) ? zombie1 : zombie2; // 50% of probability to have zombie1 or zombie2

            //int turn = random.Next(100);
            //Zombie current_attacker = (turn <= 50) ? zombie1 : zombie2;

            while (!current_attacker.Is_Dead() && !current_attacker.Target.Is_Dead()) //current_attacker.Is_Dead() == false && current_attacker.Target.Is_Dead() == false
            {                              //!current_attacker.Get_Target().Is_Dead()
                current_attacker.Attack();
                current_attacker = current_attacker.Target; //current_attacker = current_attacker.Get_Target()
            }
            Console.WriteLine("Game Over");
        }

    }
}
