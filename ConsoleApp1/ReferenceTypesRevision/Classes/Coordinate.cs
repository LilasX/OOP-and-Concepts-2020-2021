using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypesRevision.Classes
{
    public class Coordinate
    {
        private int x;
        private int y;
        
        public Coordinate()
        {
            this.x = 0;
            this.y = 0;
        }

        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Coordinate(Coordinate copy)
        {
            this.x = copy.x;
            this.y = copy.y;
        }

        public Coordinate Clone()
        {
            //Coordinate clone = new Coordinate();
            //clone.x = this.x;
            //clone.y = this.y;
            Coordinate clone = new Coordinate(this.x, this.y);

            return clone;
        }

        public override bool Equals(object obj)
        {
            if (obj is Coordinate)
            {
                Coordinate c = obj as Coordinate;
                //Coordinate c = (Coordinate)obj;
                if (this.x == c.x && this.y == c.y)
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return " X = " + this.x + " , Y = " + this.y;
        }

    }
}
