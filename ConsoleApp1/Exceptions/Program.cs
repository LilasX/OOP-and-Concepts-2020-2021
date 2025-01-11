using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example1();

            //Example2();

            Coordinate c1 = new Coordinate(1, 2);
            Coordinate c2 = new Coordinate(1, 2);

            bool equal = false;

            try
            {
                equal = c1.Equals("Hello");
            }
            catch (Exception myException)
            {
                Console.WriteLine("Exception : " + myException.Message);
            }
            
            if (equal)
            {
                Console.WriteLine("They are equals");
            }
            else
            {
                Console.WriteLine("They are not equals");
            }

            Console.ReadLine();
        }

        private static void Example2()
        {
            int x = 4;
            int y = 0;

            try
            {
                x = x / y;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : " + e.Message);
            }

            Console.WriteLine("X = " + x);
        }

        private static void Example1()
        {
            /*
            Coordinate c1 = new Coordinate();
            c1.X = 1;
            c1.Y = 2;
            Coordinate c2 = new Coordinate();
            c2.X = 1;
            c2.Y = 2;
            c1 = null;

            try
            {
                Console.WriteLine("X1 = " + c1.X);
                Console.WriteLine("X2 = " + c2.X);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception : " + e.Message);
            }
            */

            int[] array = new int[2];

            try
            {
                array[0] = 0;
                array[1] = 1;
                array[2] = 2;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : " + e.Message);
            }
            finally //optional
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
