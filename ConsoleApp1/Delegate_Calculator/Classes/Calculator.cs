using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Calculator.Classes
{
    public class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            try
            {
                return x / y;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception : " + exception.Message);
            }
            return 0;
        }
    }
}
