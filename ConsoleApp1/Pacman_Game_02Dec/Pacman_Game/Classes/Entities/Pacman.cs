using Pacman_Game.Classes.Pathfinding;
using Pacman_Game.Classes.States;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman_Game.Classes.Entities
{
    public delegate void PacmanUpdated();

    public class Pacman : LivingEntity
    {
        private event PacmanUpdated PacmanMoved = null;
        private event PacmanUpdated PacmanBoosted = null;
        private event PacmanUpdated PacmanNormal = null;

        //NONE, UP, DOWN, LEFT, RIGHT
        private static string[] image_files = {"Pacman_None.png",
                                               "Pacman_Up.png",
                                               "Pacman_Down.png",
                                               "Pacman_Left.png",
                                               "Pacman_Right.png"};
        private int lives;
        private IState state;

        private const int BOOST_DURATION = 15000;//5000 mili-Seconds
        private DateTime start_boost_time;
        private int EatenGhosts = 0;

        public Pacman(int row, int column) : base(row, column)
        {
            this.Lives = 3;
            base.Current_Direction = Direction.LEFT;
            this.state = NormalState.GetInstance();
        }

        public int Lives { get => lives; set => lives = value; }
        
        public void Subscribe(Ghost ghost)
        {
            this.PacmanMoved   += ghost.UpdatePath;
            this.PacmanBoosted += ghost.EnableScared;
            this.PacmanNormal  += ghost.DisableScared;
        }
        public bool BoostTimeOut()
        {
            if(DateTime.Now.Subtract(start_boost_time).TotalMilliseconds >= BOOST_DURATION)
            {
                return true;
            }
            return false;
        }

        public override void Draw(Graphics graphics)
        {
            //Drawing the background
            int pointX, pointY;
            base.DrawBackground(graphics, Color.Black, out pointX, out pointY);
            //Choosing an image
            int index = (int)base.Current_Direction;
            string file_name = image_files[index];
            
            //Drawing Pacman
            int side = Map.Tile_size;
            Rectangle myRectangle = new Rectangle(pointX, pointY, side, side);
            using (Image myImage = Image.FromFile(Map.path + file_name))
            {
                graphics.DrawImage(myImage, myRectangle);
            }

        }
        public override void Move()
        {
        
            int vx = 0, vy = 0;
            switch (base.Current_Direction)
            {
                case Direction.UP://-1 (ROW) , COLUMN
                    vx = 0;//COLUMN
                    vy = -1;//ROW
                    break;
                case Direction.DOWN://+1 (ROW), COLUMN
                    vx = 0;
                    vy = 1;
                    break;
                case Direction.LEFT:// ROW, -1 (COLUMN)
                    vx = -1;
                    vy = 0;
                    break;
                case Direction.RIGHT:// ROW, 1 (COLUMN)
                    vx = 1;
                    vy = 0;
                    break;
            }

            int next_Column = this.Column + vx;
            int next_Row = this.Row + vy;
            AbstractEntity entity = Map.matrix_entities[next_Row, next_Column];

            if (this.CanPassThrough(entity))
            {
                this.Column = next_Column;
                this.Row = next_Row;

                if(this.PacmanMoved != null)
                {
                    this.PacmanMoved.Invoke();
                }

                if (this.CanEat(entity))
                {
                    this.Eat(entity);
                }
                if (this.state.CanEatGhost())//BoostedState
                {
                    //Eat the Ghosts
                    foreach (Ghost ghost in Game_Manager.ListGhosts)
                    {
                        if(this.Row == ghost.Row && this.Column == ghost.Column)
                        {
                            EatenGhosts ++;
                            //Change the state of ghost to Eaten
                            ghost.EnableEaten();
                            //increase the score of pacman + 200, +400, +600, +800
                            this.Score += (EatenGhosts * 200); 
                        }
                    }
                }
            }
            if (this.state is BoostedState)
            {
                if (this.BoostTimeOut())
                {
                    EatenGhosts = 0;
                    this.state = NormalState.GetInstance();

                    if(this.PacmanNormal != null)
                    {
                        this.PacmanNormal.Invoke();
                    }
                }
            }


        }
        public override void Eat(AbstractEntity entity)
        {
            
                this.Score += entity.Score;
                Map.matrix_entities[entity.Row, entity.Column] = new EmptyTile(entity.Row, entity.Column);
                Map.Count_Eatable_Entities--;

                if(entity is Booster)
                {
                    this.state = BoostedState.GetInstance();
                    this.start_boost_time = DateTime.Now;
                    if(this.PacmanBoosted != null)
                    {
                        this.PacmanBoosted.Invoke();
                    }
                }
                if (Map.Count_Eatable_Entities == 0)
                {
                    MessageBox.Show("You are winner !");
                }
                 
        }
        public bool CanPassThrough(AbstractEntity entity)
        {
            //return (entity is Dot) || (entity is Booster) || (entity is Fruit)|| (entity is EmptyTile) ;
            return !(entity is Wall) && !(entity is GhostRoom);
        }
        public bool CanEat(AbstractEntity entity)
        {
            return (entity is Dot) || (entity is Booster) || (entity is Fruit) ;
        }
    }
}
