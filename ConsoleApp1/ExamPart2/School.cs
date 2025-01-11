using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPart2
{
    static class School
    {
        //static ArrayList + initialize
        private static ArrayList list_students = new ArrayList();

        //Void Add
        public static void Add(Student p)
        {
            School.list_students.Add(p);
        }

        //Count
        public static int Count()
        {
            int count = 0;
            while(count<School.list_students.Count)
            {
                count++;
            }
            return count;
        }

        //Student Search_By_ID
        public static Student Search_By_ID(int ID)
        {

            for (int i = 0; i < list_students.Count; i++)
            {
                Student obj = (Student)School.list_students[i];
                if (obj.Id == ID)
                {
                    return obj;
                }
            }
            return null;
        }

        //Void Display
        public static void Display()
        {
            foreach (Student obj in School.list_students)
            {
                Console.WriteLine(obj.ToString() + "\n");
            }
        }
    }
}
