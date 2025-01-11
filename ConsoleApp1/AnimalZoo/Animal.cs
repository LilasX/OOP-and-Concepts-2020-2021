using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Animal
    {
        public int age;
        public int weight;
        public string gender;

        public Animal(int age, int weight, String gender)
        {
            this.age = age;
            this.weight = weight;
            this.gender = gender;
        }

        public void Eat()
        {
            Console.WriteLine("The animal is eating...");
        }

        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping...");
        }

        public virtual void Speak() //this is a potential problem
        {
            Console.WriteLine("The animal's age is " + age);
            Console.WriteLine("The animal's weight is " + weight);
            Console.WriteLine("The animal's gender is " + gender);
        }

    }
}
