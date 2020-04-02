using PNGGAME.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Model
{
    public class Card
    {
        private string _code;
        private Enums.Suit _suit;
        private Enums.Rank _rank;

        public string Code => this._code;
        public Enums.Suit Suit => this._suit;
        public Enums.Rank Rank => this._rank;

        /// <summary>
        /// Instantiate Card / Card Constructor
        /// </summary>
        /// <param name="rank">Card Rank Type (Enums)</param>
        /// <param name="suit">Card Suit Type (Enums)</param>
        public Card(Enums.Rank rank, Enums.Suit suit)
        {
            this._rank = rank;
            this._suit = suit;
            this._code = CardHelper.GetCardCode(this);
        }
    }
}
