using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Sparrow : Bird, Flyable, Singlable
    {
        public Sparrow(int age, int weight, String gender) : base(age, weight, gender)
        {

        }


        public void Fly()
        {
            Console.WriteLine("The sparrow is flying high...");
        }

        public void Sing()
        {
            Console.WriteLine("The Sparrow is singing...");
        }

    }
}
