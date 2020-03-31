using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal class PokerPlayer : IPlayer
    {
        private string _name;
        private Hand _hand;
        private int _totalScore;
        public string Name { get => this._name; set => this._name = value; }
        internal Hand Hand { get => this._hand; set => this._hand = value; }
        public int TotalScore => this._totalScore;

        internal PokerPlayer()
        {
            this._hand = new Hand();
        }

        internal void SetHand(Hand hand)
        {
            this._hand = hand;
        }
    }
}
