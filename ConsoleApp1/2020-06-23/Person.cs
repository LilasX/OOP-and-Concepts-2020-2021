using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_06_23
{
    class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(String name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat() //all is sharing this method
        {
            Console.WriteLine("The person is eating...");
        }

        public virtual void Display()
        {
            Console.WriteLine("Name : " + Name + " , Age : " + Age);
        }

    }
}
