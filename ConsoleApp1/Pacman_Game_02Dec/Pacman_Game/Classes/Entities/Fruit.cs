using System;
using System.Collections.Generic;
using System.Drawing;
using Pacman_Game.Classes.Pathfinding;

namespace Pacman_Game.Classes.Entities
{
    public class Fruit: AbstractEntity
    {
        private static string[] image_files = {"Fruit_Apple.png", 
                                               "Fruit_Cherry.png",
                                               "Fruit_Strawberry.png"};
        private string file_name;

        public Fruit(int row, int column):base(100,row, column)
        {
            int count = Fruit.image_files.Length;
            int index = RNG.Get_Instance().Next(0, count);// the value count is exclusive
            this.file_name = Fruit.image_files[index];
        }

        public override void Draw(Graphics graphics)
        {
            //Drawing the background
            int pointX, pointY;
            base.DrawBackground(graphics, Color.Black, out pointX, out pointY);
            
            //Drawing the Fruit
            int side = Map.Tile_size;
            Rectangle myRectangle = new Rectangle(pointX, pointY, side, side);
            using (Image myImage = Image.FromFile(Map.path + file_name))
            {
                graphics.DrawImage(myImage, myRectangle);
            }
        }
    }
}
