using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReferenceTypes.Classes
{
    class Coordinate
    {
        private double x;
        private double y;

        public Coordinate()
        {
            this.x = 0;
            this.y = 0;
        }
        public Coordinate(Coordinate copy)
        {
            this.X = copy.X;
            this.Y = copy.Y;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public Coordinate Clone()
        {
            Coordinate myClone = new Coordinate();
            myClone.X = this.X;
            myClone.Y = this.Y;

            return myClone;
        }

        public override string ToString()
        {
            return "X = " + this.x + " , Y = " + this.y;
        }

        public override bool Equals(object obj)
        {
            if (obj is Coordinate)
            {
                //Coordinate obj_coordinate = (Coordinate)obj;
                Coordinate obj_coordinate = obj as Coordinate;
                //if(this.X == obj_coordinate.X)
                if (this.X == ((Coordinate)obj).X && this.Y == (obj as Coordinate).Y)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
