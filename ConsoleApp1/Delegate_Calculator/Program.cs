using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegate_Calculator.Classes;

namespace Delegate_Calculator
{
    public delegate double Operation(double x, double y);

    class Program
    {
        static void Main(string[] args)
        {
            Operation operation1 = new Operation(Calculator.Add);
            double x = 10;
            double y = 20;
            double result1 = operation1.Invoke(x, y);
            Console.WriteLine("Result 1 = " + result1);

            Operation operation2 = new Operation(Calculator.Add);
            double a = 10;
            double b = 20;
            double result2 = operation2.Invoke(a, b);
            Console.WriteLine("Result 2 = " + result2);

            Console.ReadKey();
        }
    }
}
