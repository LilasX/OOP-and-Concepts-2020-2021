using FinalProjectMaze.Classes.Pathfinding;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectMaze.Classes.Entities
{
    public class Food : AbstractEntity
    {
        private static string[] image_files = {"berries.png",
                                               "worm.png"};
        private string file_name;

        public Food(int row, int column) : base(100, row, column)
        {
            int count = Food.image_files.Length;
            int index = RNG.Get_Instance().Next(0, count);
            this.file_name = Food.image_files[index];
        }

        public override void Draw(Graphics graphics)
        {
            //Drawing the background
            int pointX, pointY;
            base.DrawBackground(graphics, Color.Green, out pointX, out pointY);

            //Drawing the Food
            int side = Map.Tile_size;
            Rectangle myRectangle = new Rectangle(pointX, pointY, side, side);
            using (Image myImage = Image.FromFile(Map.path + file_name))
            {
                graphics.DrawImage(myImage, myRectangle);
            }
        }
    }
}
