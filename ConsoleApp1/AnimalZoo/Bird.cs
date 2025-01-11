using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Bird : Animal
    {
        public Bird(int age, int weight, String gender) : base(age, weight, gender)
        {

        }
        
        public override void Speak()
        {
            Console.WriteLine("The bird's age is " + age);
            Console.WriteLine("The bird's weight is " + weight);
            Console.WriteLine("The bird's gender is " + gender);
        }
        
        public virtual void Fly()
        {
            Console.WriteLine("The bird is flying...");
        }
        

        public void Fight()
        {
            Console.WriteLine("The bird is fighting...");
        }

    }
}
