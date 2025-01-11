using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Eagle : Bird
    {
        public Eagle(int age, int weight, String gender) : base(age, weight, gender)
        {

        }

        public override void Fly()
        {
            Console.WriteLine("Actually, the eagle is flying really high...");
        }

    }
}
