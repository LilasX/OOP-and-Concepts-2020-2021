using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] ArrayFinal = new double[5];
            double[] ArrayMidterm = new double[5];
            double[] ArrayProject = new double[5];
            double[] ArrayGrade = new double[5];
            int[] ArrayStudent = new int[5];
            int counter = 0;
            string response;
            int i;
            int studentid = 0;

            do
            {
                Console.Write("Enter your student ID : ");
                string inputid = Console.ReadLine();
                studentid = Convert.ToInt32(inputid);
                ArrayStudent[counter] = studentid;
                Console.WriteLine("The student ID entered : " + studentid);
                Console.WriteLine();

                Console.Write("Enter your final grade : ");
                string input = Console.ReadLine();
                double finalgrade = Convert.ToDouble(input);
                ArrayFinal[counter] = finalgrade;
                Console.WriteLine("The grade entered : " + finalgrade);
                Console.WriteLine();

                Console.Write("Enter your midterm grade : ");
                string input2 = Console.ReadLine();
                double midtermgrade = Convert.ToDouble(input2);
                ArrayMidterm[counter] = midtermgrade;
                Console.WriteLine("The grade entered : " + midtermgrade);
                Console.WriteLine();

                Console.Write("Enter your project grade : ");
                string input3 = Console.ReadLine();
                double projectgrade = Convert.ToDouble(input3);
                ArrayProject[counter] = projectgrade;
                Console.WriteLine("The grade entered : " + projectgrade);
                Console.WriteLine();

                double finalizedgrade;
                finalizedgrade = (finalgrade*0.4 + midtermgrade*0.3 + projectgrade*0.3);
                finalizedgrade = Math.Round(finalizedgrade);
                ArrayGrade[counter] = finalizedgrade;
                Console.WriteLine("Your finalized grade : " + finalizedgrade);
                Console.WriteLine();

                counter++;
                
                Console.WriteLine("Do you want to continue ? (Y/N)");
                response = Console.ReadLine();
                Console.WriteLine();
            } while ((response == "Y" || response == "y") && counter < 5);

            for(i=0;i<5;i++)
            {
                Console.WriteLine("Student ID " + ArrayStudent [i] + " " + ArrayFinal[i] + " " + ArrayMidterm[i] + " " + ArrayProject[i] + " " + ArrayGrade[i]);
            }
            
            Console.ReadLine();
        }
    }
}
