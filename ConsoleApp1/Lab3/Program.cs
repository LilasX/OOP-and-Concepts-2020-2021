using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students : ");
            string input = Console.ReadLine();
            int size = Convert.ToInt32(input);
            double[,] grade = new double[3, size];

            for(int i =0; i<grade.GetLength(1); i++)
            {
                Console.WriteLine("Enter midterm grade : ");
                input = Console.ReadLine();
                grade[0, i] = Convert.ToDouble(input);

                Console.WriteLine("Enter project grade : ");
                grade[1, i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter final exam grade : ");
                grade[2, i] = Convert.ToDouble(Console.ReadLine());

                double finalgrade = (0.3 * grade[0, i]) + (0.3 * grade[1, i]) + (0.4 * grade[2, i]);
                Console.WriteLine("Final Grade : " + Math.Round(finalgrade));

            }
            Console.ReadLine();
        }
    }
}
