using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird(1, 2, "male");
            //bird.Speak();

            Sparrow sparrow = new Sparrow(1, 2, "male");
            sparrow.Fly();

            Chicken chick = new Chicken(1, 2, "male");
            //chick.Eat();
            //chick.Sleep();
            //chick.Speak();

            //chick.Fly();

            Console.ReadKey();
        }
    }
}
