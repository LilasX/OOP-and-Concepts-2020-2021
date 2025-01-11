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

        static GameManager()
        {
            bird = new Bird(4, 0);
        }

        public static void Start_Game()
        {
            Map.Load_Data();
        }
    }
}
