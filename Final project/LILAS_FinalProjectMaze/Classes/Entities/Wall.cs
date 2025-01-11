using FinalProjectMaze.Classes.Pathfinding;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProjectMaze.Classes.Entities
{
    public class Wall : AbstractEntity
    {

        public Wall(int row, int column) : base(0, row, column)   { }

        public override void Draw(Graphics graphics)
        {
            //Drawing the background
            int pointX, pointY;
            base.DrawBackground(graphics, Color.SaddleBrown, out pointX, out pointY);

            //Drawing the Wall
            int side = Map.Tile_size;
            Rectangle myRectangle = new Rectangle(pointX, pointY, side, side);
            using (Image myImage = Image.FromFile(Map.path + "rock.png"))
            {
                graphics.DrawImage(myImage, myRectangle);
            }
        }
    }
}
