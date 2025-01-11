using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_06_23
{
    class Student : Person
    {
        private static int nextID = 0;
        public int StudentID { get; private set; }
        public Student(string name, int age) : base(name, age)
        {
            StudentID = nextID;
            nextID++;
        }

        public override void Display()
        {
            Console.WriteLine("Student named " + Name + " has student ID " + StudentID);
        }

        public void Study()
        {
            Console.WriteLine("Student is studying...");
        }

    }
}
