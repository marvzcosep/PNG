using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Common
{
    internal static class Enums
    {
        /// <summary>
        /// List of Suits
        /// </summary>
        internal enum Suit
        {
            Hearts,     // Hearts
            Spades,     // Spades
            Clover,     // Clover
            Diamonds    // Diamond
        }

        /// <summary>
        /// List of Rank sorted by score
        /// </summary>
        internal enum Rank
        {
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }

        /// <summary>
        /// List of Hands Type sorted by score
        /// </summary>
        internal enum HandType
        {
            HighCard,
            OnePair,
            TwoPair,
            ThreeOfAKind,
            Straight,
            Flush,
            FullHouse,
            FourOfAKind,
            StraightFlush,
            RoyalFlush
        }
    }
}
