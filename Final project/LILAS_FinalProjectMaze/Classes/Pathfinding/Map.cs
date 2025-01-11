using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectMaze.Classes.Entities;

namespace FinalProjectMaze.Classes.Pathfinding
{
    public static class Map
    {
        public static readonly int Tile_size = 20; //20 pixels
        public static readonly string path = "../../Classes/Resources/";
        public static readonly string file = "Map.txt";


        public static AbstractEntity[,] matrix_entities = null;
        public static int Max_rows;
        public static int Max_columns;

        public static void Load_Data()
        {
            string[] lines = File.ReadAllLines(Map.path + Map.file);
            Map.Max_rows = lines.Length;
            Map.Max_columns = lines[0].Length;

            matrix_entities = new AbstractEntity[Map.Max_rows, Map.Max_columns];

            int row = 0;

            foreach (string line in lines)
            {
                char[] chars = line.ToCharArray();
                Map.Max_columns = chars.Length;

                int column = 0;

                foreach (char character in chars)
                {
                    AbstractEntity obj = null;

                    switch (character)
                    {
                        case '#': //Create Wall
                            obj = new Wall(row, column);
                            break;
                                                  
                        case 'H': //Create Home/Goal
                            obj = new Home(row, column);
                            break;

                        default:
                            obj = new EmptyTile(row, column);
                            break;

                    }
                    matrix_entities[row, column] = obj;
                    column++;
                }
                row++;
            }
        }
    }
}
