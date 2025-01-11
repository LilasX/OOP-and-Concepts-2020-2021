using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypesRevision.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate c1 = new Coordinate();
            Coordinate c2 = new Coordinate();

            Console.WriteLine("C1 : " + c1.ToString());
            Console.WriteLine("C2 : " + c2.ToString());
            
            if(c1.Equals(c2))
            {
                Console.WriteLine("They are equal");
            }
            else
            {
                Console.WriteLine("They are different");
            }

            //Coordinate c3 = new Coordinate(c2);
            Coordinate c3 = c2.Clone();
            c3.X = 10;
            c3.Y = 20;
            Console.WriteLine("C1 : " + c1.ToString());
            Console.WriteLine("C2 : " + c2.ToString());
            Console.WriteLine("C3 : " + c3.ToString());

            //Passing a reference as parameter
            Console.WriteLine("Passing as parameter c3");
            Passing_obj_by_Reference(c3);
            Console.WriteLine("C3 : " + c3.ToString());
            Console.WriteLine("Passing as parameter c3.Clone()");
            Passing_obj_by_Reference(c3.Clone());
            Console.WriteLine("C3 : " + c3.ToString());

            int age = 20;
            Console.WriteLine("Passing int parameter by value");
            Passing_val_by_Value(age);
            Console.WriteLine("Age = " + age);
            Console.WriteLine("Passing int parameter by reference");
            Passing_val_by_Reference(ref age);
            Console.WriteLine("Age = " + age);

            Console.ReadKey();
        }

        static void Passing_obj_by_Reference(Coordinate c)
        {
            c.X++;
            c.Y++;
        }

        static void Passing_val_by_Value(int x)
        {
            x++;
        }

        static void Passing_val_by_Reference(ref int x)
        {
            x++;
        }

    }
}
