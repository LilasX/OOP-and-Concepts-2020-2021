using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    public class Team
    {
        private List<Player> list_players;

        public Team()
        {
            this.list_players = new List<Player>();
        }

        public void Add(params Player[] p)
        {
            for(int i = 0; i < p.Length; i++)
            {
                this.list_players.Add(p[i]);
            }
            
        }

        public void Add(Player p)
        {
            this.list_players.Add(p);
        }

        public int Count()
        {
            return this.list_players.Count;
        }

        public Player Search_By_ID(int ID)
        {
            for (int i = 0; i < this.list_players.Count; i++)
            {
                if(this.list_players[i].Id == ID)
                {
                    return list_players[i];
                }
            }
            return null;
        }

        public void Display()
        {
            foreach(Player number in this.list_players)
            {
                Console.WriteLine(number.ToString());
            }
        }

    }
}
