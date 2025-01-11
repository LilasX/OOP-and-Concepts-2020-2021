using Pacman_Game.Classes.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace Pacman_Game.Classes.Pathfinding
{
    public static class Map
    {
        public static readonly int Tile_size = 20; //20 pixels
        public static readonly string path = @"../../Classes/Resources/";
        //public static readonly string path = @"..\..\Classes\Resources\";
        public static readonly string file = "Map.txt";

        public static AbstractEntity[,] matrix_entities = null;
        public static int Max_rows;
        public static int Max_columns;
        public static int Count_Eatable_Entities = 0;
        public static List<GhostRoom> ghostRooms = null;

        public static void Load_Data()
        {
            Map.ghostRooms = new List<GhostRoom>();

            string[] lines = File.ReadAllLines(Map.path + Map.file);
            Map.Max_rows = lines.Length;
            Map.Max_columns = lines[0].Length;
            matrix_entities = new AbstractEntity[Map.Max_rows, Map.Max_columns];
            
            int row = 0;

            foreach(string line in lines)
            {
                char[] chars = line.ToCharArray();
                Map.Max_columns = chars.Length;

                int column = 0;
                foreach (char character in chars)
                {
                    AbstractEntity obj = null;
                    switch (character)
                    {
                        case 'W'://Create Wall
                            obj = new Wall(row, column);
                            break;
                        case 'B'://Create Booster
                            obj = new Booster(row, column);
                            Map.Count_Eatable_Entities++;
                            break;
                        case 'D'://Create Dot
                            obj = new Dot(row, column);
                            Map.Count_Eatable_Entities++;
                            break;
                        case 'F'://Create Fruit
                            obj = new Fruit(row, column);
                            Map.Count_Eatable_Entities++;
                            break;
                        case 'R': //Ghost Room
                            obj = new GhostRoom(row, column);
                            Map.ghostRooms.Add(new GhostRoom(row, column));

                            break;
                        default:
                            obj = new EmptyTile(row, column);
                            break;
                    }
                    //Map.entities.Add(obj);
                    matrix_entities[row, column] = obj;
                    column++;
                }
                row++;
            }
        }
    }
}
