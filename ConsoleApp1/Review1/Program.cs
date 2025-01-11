using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Review1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player hockeyplayer1 = new HockeyPlayer(1, "Chen");
            Player hockeyplayer2 = new HockeyPlayer(2, "Li");
            Player hockeyplayer3 = new HockeyPlayer(3, "Gao");
            Player hockeyplayer4 = new HockeyPlayer(4, "Hu");
            Player hockeyplayer5 = new HockeyPlayer(5, "Zhang");

            Team hockeyTeam = new Team();

            hockeyTeam.Add(hockeyplayer1, hockeyplayer2, hockeyplayer3, hockeyplayer4, hockeyplayer5);

            if(hockeyplayer5 is HockeyPlayer)
            {
                (hockeyplayer5 as HockeyPlayer).TakePenalty(1);
            }
            hockeyplayer5.Play();

            Thread.Sleep(62000); //Pause of 1 min and 2 secs
            hockeyplayer5.Play();
            

            Console.ReadKey();
        }
    }
}
