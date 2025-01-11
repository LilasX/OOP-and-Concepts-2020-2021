using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Pacman_Game.Classes.Pathfinding;
using Pacman_Game.Classes.Behaviors;

namespace Pacman_Game.Classes.Entities
{
    public class Ghost:LivingEntity
    {
        private static string[,] image_matrix = { { "Blue_Ghost_None.png", "Blue_Ghost_Up.png", "Blue_Ghost_Down.png", "Blue_Ghost_Left.png", "Blue_Ghost_Right.png" } ,
                                                  { "Orange_Ghost_None.png", "Orange_Ghost_Up.png", "Orange_Ghost_Down.png", "Orange_Ghost_Left.png", "Orange_Ghost_Right.png" } ,
                                                  { "Pink_Ghost_None.png", "Pink_Ghost_Up.png", "Pink_Ghost_Down.png", "Pink_Ghost_Left.png", "Pink_Ghost_Right.png" },
                                                  { "Red_Ghost_None.png", "Red_Ghost_Up.png", "Red_Ghost_Down.png", "Red_Ghost_Left.png", "Red_Ghost_Right.png" },
                                                  { "Scared_Ghost_None.png", "Scared_Ghost_Up.png", "Scared_Ghost_Down.png", "Scared_Ghost_Left.png", "Scared_Ghost_Right.png" },
                                                  { "Dead_Ghost_None.png", "Dead_Ghost_Up.png", "Dead_Ghost_Down.png", "Dead_Ghost_Left.png", "Dead_Ghost_Right.png" }
                                                };
        private GhostColor ghost_color;
        private IBehavior current_Behavior;
        private readonly IBehavior default_Behavior;

        private Pacman target;

        public Ghost(int row, int column, GhostColor color, Pacman pacman, IBehavior behavior) :base(row, column)
        {
            this.ghost_color = color;
            base.Current_Direction = Direction.NONE;
            base.Score = 200;

            this.target = pacman;
            this.target.Subscribe(this);//Subscribe the current ghost object to the events of pacman

            this.current_Behavior = behavior;
            this.default_Behavior = behavior;
        }
        public override void Draw(Graphics graphics)
        {
            //Drawing the background
            int pointX, pointY;
            base.DrawBackground(graphics, Color.Black, out pointX, out pointY);

            //Choosing an image
            int index_row = 0; 
            if(this.current_Behavior == default_Behavior)
            {
                index_row = (int)this.ghost_color;
            }else
            if(this.current_Behavior is ScaredBehavior)
            {
                index_row = 4;
            }
            else
            if(this.current_Behavior is EatenBehavior)
            {
                index_row = 5;
            }

            int index_column = (int)base.Current_Direction;
            string file_name = image_matrix[index_row, index_column];

            //Drawing Ghost
            int side = Map.Tile_size;
            Rectangle myRectangle = new Rectangle(pointX, pointY, side, side);
            using (Image myImage = Image.FromFile(Map.path + file_name))
            {
                graphics.DrawImage(myImage, myRectangle);
            }
        }
        public override void Eat(AbstractEntity entity)
        {
            if(entity is Pacman)
            {
                (entity as Pacman).Lives--;
                //event PacmanCaught Reset Game if Lives >0 else GameOver
            }
           
        }
        public void DisableScared()
        {
            this.current_Behavior = this.default_Behavior;
            this.UpdatePath();
        }
        public void EnableScared()
        {
            this.current_Behavior = ScaredBehavior.Get_Instance();
            this.UpdatePath();
        }
        public void EnableEaten()
        {
            this.current_Behavior = EatenBehavior.Get_Instance();
            this.UpdatePath();
        }
        public void UpdatePath()
        {

        }
        public override void Move()
        {
        
        }
    }
}
