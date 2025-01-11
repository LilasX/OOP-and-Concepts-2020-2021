using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review1
{
    public class SoccerPlayer : Player
    {
        private SoccerPosition position;
        private SoccerState state;

        public SoccerPlayer() : base()
        {

        }

        public SoccerPlayer(int id, string name) : base(id, name)
        {
            this.position = SoccerPosition.None;
            this.state = SoccerState.Active;
        }

        public override void Play()
        {
            if(this.state == SoccerState.Active || this.state == SoccerState.Warning)
            {
                Console.WriteLine("Player is playing...");
            }
            else
            {
                Console.WriteLine("Player cannot play...");
            }
        }

        public void TakeCard(Card card)
        {
            if(card == Card.Red)
            {
                this.state = SoccerState.Suspended;
            }
            else if (card == Card.Yellow)
            {
                if(this.state == SoccerState.Active)
                {
                    this.state = SoccerState.Warning;
                }
                else if (this.state == SoccerState.Warning)
                {
                    this.state = SoccerState.Suspended;
                }
            }
        }

    }
}
