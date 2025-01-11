using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    public abstract class Player
    {
        private int id;
        private string name;

        protected Player()
        {
            this.id = 0;
            this.name = null;
        }

        protected Player(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return "ID : " + this.id + " , Name : " + this.name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Player)
            {
                Player p = obj as Player;
                if (this.id == p.id)
                {
                    return true;
                }
            }
            return false;
        }

        public abstract void Play();
    }
}
