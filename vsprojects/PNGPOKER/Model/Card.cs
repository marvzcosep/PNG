using PNGPOKER.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal class Card
    {
        private string _code;
        private Enums.Suit _suit;
        private Enums.Rank _rank;

        internal string Code => this._code;
        internal Enums.Suit Suit => this._suit;
        internal Enums.Rank Rank => this._rank;

        /// <summary>
        /// Instantiate Card
        /// </summary>
        /// <param name="rank">Card Rank Type (Enums)</param>
        /// <param name="suit">Card Suit Type (Enums)</param>
        internal Card(Enums.Rank rank, Enums.Suit suit)
        {
            this._rank = rank;
            this._suit = suit;
            this._code = CardHelper.GetCardCode(this);
        }
    }
}
