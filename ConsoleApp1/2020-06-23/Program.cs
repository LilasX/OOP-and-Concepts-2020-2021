using System;
using System.Collections.Generic;
using _2020_06_23.Class_2020_06_30;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020_06_23
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Teacher t11 = new Teacher("AI", 26);
            Student s1 = new Student("IA", 18);

            //Student s1 = give me a space to store an address of an object of type Student

            Person p1 = (Person)s1; //redundant
            Person p2 = new Teacher("Potato", 30); //casting = converting
            p2.Display();

            Teacher t1 = (Teacher)p2;

            List<Person> people = new List<Person>();
            people.Add(new Person("Lye", 20));
            people.Add(new Student("Lu", 21));
            people.Add(new Student("Yin", 22));
            people.Add(new Teacher("Tan", 23));
            people.Add(new Student("Yang", 24));

            foreach(Person p in people)
            {
                p.Display();
            }*/

            //MethodOverLoading_1  2020-06-30

            var shapes = new List<Shape>(); //the compiler at the compile time understand the type of var
            shapes.Add(new Shape { Width = 100, Height = 100, Type = ShapeType.Circle });
            shapes.Add(new Shape { Width = 100, Height = 100, Type = ShapeType.Rectangle });
            shapes.Add(new Shape { Width = 100, Height = 100, Type = ShapeType.Triangle });

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);



            Console.ReadKey();
        }
    }
}
