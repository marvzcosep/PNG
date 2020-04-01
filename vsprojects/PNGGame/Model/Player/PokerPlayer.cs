using PNGGAME.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Model
{
    public class PokerPlayer : Player
    {
        private Hand _hand;
        public Hand Hand { get => this._hand; set => this._hand = value; }

        public PokerPlayer()
        {
            this._hand = new Hand();
        }

        public void SetHand(Hand hand)
        {
            this._hand = hand;
        }
    }
}
