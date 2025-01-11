using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReferenceTypes.Classes;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate c1;
            c1 = new Coordinate();
            c1.X = 1;
            c1.Y = 2;
            Console.WriteLine("C1 = " + c1.ToString());

            Coordinate c2;
            c2 = new Coordinate();
            c2.X = 1;
            c2.Y = 2;
            Console.WriteLine("C2 = " + c2.ToString());

            if (c1.Equals(c2))
            {
                Console.WriteLine("C1 == C2");
            }
            else
            {
                Console.WriteLine("C1 != C2");
            }

            //========================================

            // Coordinate c3 = c2;  //Error of logic
            //Coordinate c3 = new Coordinate(c2); //duplicate object c2
            Coordinate c3 = c2.Clone();
            c3.X = 10;
            Console.WriteLine("C2 = " + c2.ToString());
            Console.WriteLine("C3 = " + c3.ToString());

            //========================================

            int index = 10;
            Console.WriteLine("Before Increment_By_Value Index = " + index);
            Increment_By_Value(index);
            Console.WriteLine("After Increment_By_Value Index = " + index);
            
            Increment_By_Reference(ref index);
            Console.WriteLine("After Increment_By_Reference Index = " + index);

            //========================================

            Console.WriteLine("Before Increment c1 = " + c1.ToString());
            Increment_By_Ref(c1);
            Console.WriteLine("After Increment c1 = " + c1.ToString());

            Console.WriteLine("Before Increment c2 = " + c2.ToString());
            Increment_By_Ref(c2.Clone()); //Pass value of c2
            Console.WriteLine("After Increment c2 = " + c2.ToString());

            Console.ReadLine();
        }
        static void Increment_By_Ref(Coordinate c)
        {
            c.X++;
            c.Y++;
        }
        static void Increment_By_Value(int count)
        {
            count++;
            Console.WriteLine("Count = " + count);
        }
        static void Increment_By_Reference(ref int count)
        {
            count++;
            Console.WriteLine("Count = " + count);
        }
    }
}
