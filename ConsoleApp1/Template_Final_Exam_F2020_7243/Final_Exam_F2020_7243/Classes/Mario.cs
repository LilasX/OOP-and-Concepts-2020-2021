using Final_Exam_F2020_7243.Classes.State;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam_F2020_7243.Classes
{
    public enum Direction { NONE, UP, DOWN, LEFT, RIGHT }
   
    public class Mario : Entity
    {
        static Image image = Image.FromFile(Maze.path + "MarioSmall.png");

        private int energy;
        private readonly int energy_Max;

        private int keys;
        private int lives;
        private Direction current_Direction;
        private IState state;

        public Mario(int row, int column) : base (row, column)
        {
            this.energy = 100;
            this.energy_Max = 100;
            this.keys = 0;
            this.lives = 3;
            this.current_Direction = Direction.NONE;
            this.state = Normal_State.GetInstance();
        }

        public int Energy { get => energy; set => energy = value; }

        public int Energy_Max => energy_Max;

        public int Keys { get => keys; set => keys = value; }
        public int Lives { get => lives; set => lives = value; }
        public Direction Current_Direction { get => current_Direction; set => current_Direction = value; }
        public IState State { get => state; set => state = value; }

        public void Heal()
        {
            energy = energy_Max;
        }

        public void LooseEnergy(int energy)
        {
            Energy -= energy;

            if(Energy <= 0)
            {
                Lives--;

                if (Lives <= 0)
                {
                    GameController.GameOver();
                }
                else
                {
                    Heal();
                }
            }
        }

        public void OpenDoor(Entity entity)
        {
            if (entity is Item && (entity as Item).ItemType == Type.DOOR)
            {
                if(Keys > 0)
                {
                    Keys--;
                    Maze.Remove_Entity(entity.Row, entity.Column);
                }
            }
        }

        
         public void Move()
         {
             Point velocity = GetVelocity();
             int next_Row = this.Row + velocity.Y;
             int next_Column = this.Column + velocity.X;
             LooseEnergy(2);

             if (Maze.CheckMazeBounds(next_Row, next_Column))
             {
                 Entity next_Entity = Maze.EntityData[next_Row, next_Column];
                 if (this.CanPassThrough(next_Entity))
                 {
                    this.Row = next_Row;
                    this.Column = next_Column;

                    if (next_Entity is Item && ((Item)next_Entity).ItemType == Type.AWARD)
                    {
                        //Bonus : Invoke the event
                    }
                    if (next_Entity is Item && ((Item)next_Entity).ItemType == Type.POTION)
                    {
                        this.state.Drink_Potion(this);
                        Maze.Remove_Entity(this.Row, this.Column);
                    }
                    else if (next_Entity is Item && ((Item)next_Entity).ItemType == Type.KEY)
                    {
                        this.state.Take_Key(this);
                        Maze.Remove_Entity(this.Row, this.Column);
                    }
                    else if (next_Entity is Ghost && ((Ghost)next_Entity).Visible)
                    {
                        this.state.Hit_Ghost(this, (Ghost)next_Entity);
                    }

                 }
                 else
                 {
                     OpenDoor(next_Entity);
                 }
             }//end if
         }

         public bool CanPassThrough(Entity entity)
         {
             if (entity is Item && ((Item)entity).ItemType == Type.DOOR)
             {
                 return false;
             }
             else
             if (entity is Tile && ((Tile)entity).Type == TileType.WALL) {
                 return false;
             }
             else
             {
                 return true;
             }
         }

         //----------------------------------------------
         public override void Draw(Graphics g)
         {
             int size = Maze.cellSize;
             Rectangle bounds = new Rectangle(this.Column * size, this.Row * size, size, size);
             g.DrawImage(image, bounds);
         }
         //------------------------------------------------
         public Point GetVelocity()
         {
             switch (this.Current_Direction)
             {
                 case Direction.UP: return new Point(0, -1);
                 case Direction.DOWN: return new Point(0, 1);
                 case Direction.LEFT: return new Point(-1, 0);
                 case Direction.RIGHT: return new Point(1, 0);
                 default: return new Point(0, 0);
             }
         }
         
    }
}
