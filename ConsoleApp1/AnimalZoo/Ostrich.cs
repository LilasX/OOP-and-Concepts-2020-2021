using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Ostrich : Bird
    {
        public Ostrich(int age, int weight, String gender) : base(age, weight, gender)
        {

        }

        public override void Fly()
        {
            Console.WriteLine("The ostrich doesn't fly...");
        }

    }
}
