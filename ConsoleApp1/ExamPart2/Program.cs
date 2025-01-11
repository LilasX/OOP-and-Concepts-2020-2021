using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Two Objects Type Student
            Student Obj1 = new Student("student1", 1);
            Student Obj2 = new Student("Lilas", 1932335);

            //Student mystudent = new Student("Potato", 1);
            
            //Call Add
            School.Add(Obj1);
            School.Add(Obj2);

            //School.Add(mystudent);

            //Call Display
            School.Display();

            //Call Count
            Console.WriteLine("Number of students in the list : " + School.Count());
            Console.WriteLine();

            //Call Search_By_ID
            Student obj = School.Search_By_ID(1);
            if (obj != null)
            {
                Console.WriteLine(obj.ToString());
            }
            else
            {
                Console.WriteLine("Student is not found");
            }

            //Console.WriteLine(Obj1.Equals(mystudent));

            Console.ReadKey();
        }
    }
}
