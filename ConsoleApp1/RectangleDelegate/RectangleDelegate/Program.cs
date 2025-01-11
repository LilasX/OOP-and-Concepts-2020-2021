using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleDelegate
{
    public delegate double RectangleOperation();

    class Program
    {
        
        static void Main(string[] args)
        {
            Rectangle myRectangle = new Rectangle(15, 20);

            RectangleOperation operation = new RectangleOperation(myRectangle.CalculateArea);

            //Invoke all added operations, like a foreach loop for each method with the name operation
            operation += myRectangle.CalculatePerimeter;

            //Remove this operation before calling Invoke
            //operation -= myRectangle.CalculateArea;

            //you can choose a specific operation 
            double result = (double)operation.GetInvocationList().ElementAt(0).DynamicInvoke();

            //double result = operation(); 
            Console.WriteLine("Result = " + result);
           
            Console.ReadKey();
        }
    }
}
