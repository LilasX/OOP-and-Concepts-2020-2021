using FinalProjectMaze.Classes.Pathfinding;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectMaze.Classes.Entities
{
    public class Bird : AbstractEntity
    {
        private int wallDestroyers;
        private Direction current_Direction;
        private static string[] image_files = { "bird_none.png",
                                                "bird_up.png",
                                                "bird_down.png",
                                                "bird_left.png",
                                                "bird_right.png" };

        public Bird(int row, int column) : base(50, row, column)
        {
            this.WallDestroyers = 3;
            this.current_Direction = Direction.RIGHT;
        }

        public int WallDestroyers { get => wallDestroyers; set => wallDestroyers = value; }
        public Direction Current_Direction { get => current_Direction; set => current_Direction = value; }

        public override void Draw(Graphics graphics)
        {
            //Drawing the background
            int pointX, pointY;
            base.DrawBackground(graphics, Color.Green, out pointX, out pointY);

            //Draw Bird
            int index = (int)this.Current_Direction;
            string file_name = image_files[index];

            int side = Map.Tile_size;
            Rectangle myRectangle = new Rectangle(pointX, pointY, side, side);
            using (Image myImage = Image.FromFile(Map.path + file_name))
            {
                graphics.DrawImage(myImage, myRectangle);
            }
        }

        public void Eat(AbstractEntity entity)
        {
            this.Energy += entity.Energy;
            Map.matrix_entities[entity.Row, entity.Column] = new EmptyTile(entity.Row, entity.Column);
        }

        public void Move()
        {
            int vx = 0, vy = 0;
            switch (this.Current_Direction)
            {
                case Direction.UP: //-1 y (ROW), x (Column)
                    vx = 0;
                    vy = -1;
                    break;

                case Direction.DOWN: //+1 y (ROW), x (Column)
                    vx = 0;
                    vy = 1;
                    break;

                case Direction.LEFT: // y (ROW), -1 x (Column)
                    vx = -1;
                    vy = 0;
                    break;

                case Direction.RIGHT: // y (ROW), +1 x (Column)
                    vx = 1;
                    vy = 0;
                    break;
            }
            int next_Column = this.Column + vx;
            int next_Row = this.Row + vy;

            AbstractEntity entity = Map.matrix_entities[next_Row, next_Column];

            if (this.CanpassThrough(entity))
            {
                this.Column += vx;
                this.Row += vy; ;
                this.Eat(entity);
            }
        }
        public bool CanpassThrough(AbstractEntity entity)
        {
            return !(entity is Wall);
        }
        public void Monster_Attack()
        {

        }
    }
}
