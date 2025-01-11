using FinalProjectMaze.Classes.Entities;
using FinalProjectMaze.Classes.Pathfinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectMaze.Classes
{
    public static class GameManager
    {
        public static Bird bird;

        public static Food Food1, Food2, Food3, Food4, Food5, Food6, Food7, Food8, Food9, Food10;
        public static Fox Fox1, Fox2, Fox3, Fox4, Fox5;
        public static List<Food> FoodSpawn = null;
        public static List<Fox> FoxSpawn = null;

        static GameManager()
        {
            bird = new Bird(4, 0);
        }

        private static ObjectsSpawn GetRandom_ObjectsSpawn()
        {
            int max = Map.objectsSpawns.Count;
            int random_index = RNG.Get_Instance().Next(0, max);
            ObjectsSpawn randomObj = Map.objectsSpawns[random_index];
            Map.objectsSpawns.RemoveAt(random_index);

            return randomObj;
        }

        public static void Start_Game()
        {
            Map.Load_Data();
            FoodSpawn = new List<Food>();
            FoxSpawn = new List<Fox>();

            ObjectsSpawn Obj1 = GetRandom_ObjectsSpawn();
            Food1 = new Food(Obj1.Row, Obj1.Column);
            FoodSpawn.Add(Food1);

            ObjectsSpawn Obj2 = GetRandom_ObjectsSpawn();
            Food2 = new Food(Obj2.Row, Obj2.Column);
            FoodSpawn.Add(Food2);

            ObjectsSpawn Obj3 = GetRandom_ObjectsSpawn();
            Food3 = new Food(Obj3.Row, Obj3.Column);
            FoodSpawn.Add(Food3);

            ObjectsSpawn Obj4 = GetRandom_ObjectsSpawn();
            Food4 = new Food(Obj4.Row, Obj4.Column);
            FoodSpawn.Add(Food4);

            ObjectsSpawn Obj5 = GetRandom_ObjectsSpawn();
            Food5 = new Food(Obj5.Row, Obj5.Column);
            FoodSpawn.Add(Food5);

            ObjectsSpawn Obj6 = GetRandom_ObjectsSpawn();
            Food6 = new Food(Obj6.Row, Obj6.Column);
            FoodSpawn.Add(Food6);

            ObjectsSpawn Obj7 = GetRandom_ObjectsSpawn();
            Food7 = new Food(Obj7.Row, Obj7.Column);
            FoodSpawn.Add(Food7);

            ObjectsSpawn Obj8 = GetRandom_ObjectsSpawn();
            Food8 = new Food(Obj8.Row, Obj8.Column);
            FoodSpawn.Add(Food8);

            ObjectsSpawn Obj9 = GetRandom_ObjectsSpawn();
            Food9 = new Food(Obj9.Row, Obj9.Column);
            FoodSpawn.Add(Food9);

            ObjectsSpawn Obj10 = GetRandom_ObjectsSpawn();
            Food10 = new Food(Obj10.Row, Obj10.Column);
            FoodSpawn.Add(Food10);

            ObjectsSpawn Obj11 = GetRandom_ObjectsSpawn();
            Fox1 = new Fox(Obj11.Row, Obj11.Column);
            FoxSpawn.Add(Fox1);

            ObjectsSpawn Obj12 = GetRandom_ObjectsSpawn();
            Fox2 = new Fox(Obj12.Row, Obj12.Column);
            FoxSpawn.Add(Fox2);

            ObjectsSpawn Obj13 = GetRandom_ObjectsSpawn();
            Fox3 = new Fox(Obj13.Row, Obj13.Column);
            FoxSpawn.Add(Fox3);

            ObjectsSpawn Obj14 = GetRandom_ObjectsSpawn();
            Fox4 = new Fox(Obj14.Row, Obj14.Column);
            FoxSpawn.Add(Fox4);

            ObjectsSpawn Obj15 = GetRandom_ObjectsSpawn();
            Fox5 = new Fox(Obj15.Row, Obj15.Column);
            FoxSpawn.Add(Fox5);
        }
    }
}
