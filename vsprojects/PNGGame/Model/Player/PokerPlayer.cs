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

        /// <summary>
        /// Poker Player Constructor
        /// </summary>
        public PokerPlayer()
        {
            this._hand = new Hand();
        }

        /// <summary>
        /// Creates player hand
        /// </summary>
        /// <param name="hand"></param>
        public void SetHand(Hand hand)
        {
            this._hand = hand;
        }
    }
}
