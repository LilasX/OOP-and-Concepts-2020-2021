using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Coordinate
    {
        public int X;
        public int Y;

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
           // if (obj is Coordinate)
            //{
                //Coordinate obj_coordinate = (Coordinate)obj;
                //Coordinate obj_coordinate = obj as Coordinate;
                //if(this.X == obj_coordinate.X)
                if (this.X == ((Coordinate)obj).X && this.Y == (obj as Coordinate).Y)
                {
                    return true;
                }

           // }
            return false;
        }
    }
}
