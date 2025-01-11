using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            double[] myArray = new double[5];
            int counter = 0;
            int i;
            double final = 0;
             
            do
            {
                Console.Write("Enter the price of your product : ");
                string input = Console.ReadLine();
                double price = Convert.ToDouble(input);
                double total = (0.15 * price) + price;
                myArray[counter] = total;
                Console.WriteLine("Your total : " + total);
                counter++;
                Console.WriteLine("Do you want to continue ? (Y/N)");
                response = Console.ReadLine();
            } while ((response == "Y" || response == "y") && counter < myArray.Length); //response.ToUpper() == "y"
            for(i = 0; i<myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
                final = (myArray[0] + myArray[1] + myArray[2] + myArray[3] + myArray[4]);
            }
            Console.WriteLine("Your total amount is " + final);
            Console.ReadLine(); //Console.ReadKey(); pause
        }
    }
}