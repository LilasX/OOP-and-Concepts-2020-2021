using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Chicken : Bird
    {
        public Chicken(int age, int weight, String gender) : base(age, weight, gender)
        {

        }
        
        public override void Fly()
        {
            Console.WriteLine("The chicken doesn't fly...");
        }
        
    }
}
