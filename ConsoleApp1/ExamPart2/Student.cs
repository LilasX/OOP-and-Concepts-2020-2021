using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPart2
{
    class Student
    {
        //Attributes
        private string name;
        private int id;

        //Default constructor 
        public Student()
        {
            this.Name = null;
            this.Id = 0;
        }

        //Constructor with 2 parameters
        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        //Encapsulate name to get property
        public string Name { get => name; set => name = value; }

        //Encapsulate id to get property
        public int Id { get => id; set => id = value; }

        //Override string ToString()
        public override string ToString()
        {
            string description = "Name : " + Name + "\n" + "ID : ";
            int description_int = Id;
            return description + description_int;
        }

        //Override bool Equals(object obj)
        public override bool Equals(object obj)
        {
            if(obj is Student)
            {
                Student objStudent = obj as Student;
                if (objStudent.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
        
    }
}
