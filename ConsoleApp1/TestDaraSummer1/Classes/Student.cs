using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDaraSummer1.Classes
{
    class Student
    {
        private string id;
        private string name;
        private decimal score1;
        private decimal score2;
        private decimal score3;

        public Student(string id, string name, decimal score1, decimal score2, decimal score3)
        {
            this.Id = id;
            this.Name = name;
            this.Score1 = score1;
            this.Score2 = score2;
            this.Score3 = score3;
        }


        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        
        public decimal Score1
        {
            get
            {
                return score1;
            }
            set
            {
                if (score1 > 0)
                {
                    score1 = value;
                }
            }
        }

        public decimal Score2
        {
            get
            {
                return score2;
            }
            set
            {
                if (score2 > 0)
                {
                    score2 = value;
                }
            }
        }

        public decimal Score3
        {
            get
            {
                return score3;
            }
            set
            {
                if (score3 > 0)
                {
                    score3 = value;
                }
            }
        }

        public void GetAggregate()
        {

        }

        public void GetPercentage()
        {

        }

    }
}
