using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_06_23
{
    class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {

        }

        public override void Display()
        {
            Console.WriteLine("Teacher named " + Name);
        }

        public void GiveLecture()
        {
            Console.WriteLine("Teacher is giving lecture...");
        }

    }
}
