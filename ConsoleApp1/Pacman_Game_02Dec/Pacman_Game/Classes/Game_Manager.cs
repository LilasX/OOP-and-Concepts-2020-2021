using Pacman_Game.Classes.Behaviors;
using Pacman_Game.Classes.Entities;
using Pacman_Game.Classes.Pathfinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman_Game.Classes
{
    public static class Game_Manager
    {
        public static Pacman pacman;

        private static Ghost Inky, Blinky, Pinky, Clyde;
        public static List<Ghost> ListGhosts = null;

        static Game_Manager()
        {
            pacman = new Pacman(29, 26);
        }
        private static GhostRoom GetRandom_GhostRoom()
        {
            int max = Map.ghostRooms.Count;
            int random_index = RNG.Get_Instance().Next(0, max);
            GhostRoom randomObj = Map.ghostRooms[random_index];
            Map.ghostRooms.RemoveAt(random_index);

            return randomObj;
        }
        public static void Start_Game()
        {
            Map.Load_Data();
            ListGhosts = new List<Ghost>();

            GhostRoom Obj1 = GetRandom_GhostRoom();
            Inky = new Ghost(Obj1.Row, Obj1.Column, GhostColor.Blue, Game_Manager.pacman, FollowBehavior.Get_Instance() );
            ListGhosts.Add(Inky);

            GhostRoom Obj2 = GetRandom_GhostRoom();
            Blinky = new Ghost(Obj2.Row, Obj2.Column, GhostColor.Red, Game_Manager.pacman, ChaseBehavior.Get_Instance() );
            ListGhosts.Add(Blinky);

            GhostRoom Obj3 = GetRandom_GhostRoom();
            Pinky = new Ghost(Obj3.Row, Obj3.Column, GhostColor.Pink, Game_Manager.pacman, RandomBehavior.Get_Instance() );
            ListGhosts.Add(Pinky);

            GhostRoom Obj4 = GetRandom_GhostRoom();
            Clyde = new Ghost(Obj4.Row, Obj4.Column, GhostColor.Orange, Game_Manager.pacman, RandomBehavior.Get_Instance());
            ListGhosts.Add(Clyde);
        }
    }
}
