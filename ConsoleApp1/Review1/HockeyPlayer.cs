using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{

    public class HockeyPlayer : Player
    {
        private HockeyPosition position;
        private HockeyState state;
        private int penaltyMinutes;
        private DateTime startPenalty;

        public HockeyPlayer() : base()
        {
            
        }

        public HockeyPlayer(int id, string name) : base(id, name)
        {
            this.position = HockeyPosition.None;
            this.state = HockeyState.Active;
            this.penaltyMinutes = 0;
        }

        public override void Play()
        {
            if (this.state == HockeyState.Active)
            {
                Console.WriteLine("Player is playing...");
            }
            else
            {
                double duration = DateTime.Now.Subtract(this.startPenalty).TotalMinutes;
                if(duration >= penaltyMinutes)
                {
                    this.state = HockeyState.Active;
                    Console.WriteLine("Player is playing...");
                }
                else
                {
                    Console.WriteLine("Player cannot play...");
                }
            }
        }

        public void TakePenalty(int minutes)
        {
            this.startPenalty = DateTime.Now;
            this.penaltyMinutes = minutes;
            this.state = HockeyState.Suspended;
        }

    }
}
