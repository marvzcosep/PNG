using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Common
{
    public static class Enums
    {
        /// <summary>
        /// List of Suits
        /// </summary>
        public enum Suit
        {
            Hearts,     // Hearts
            Spades,     // Spades
            Clover,     // Clover
            Diamonds    // Diamond
        }

        /// <summary>
        /// List of Rank sorted by score
        /// </summary>
        public enum Rank
        {
            Ace,
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
            King            
        }

        /// <summary>
        /// List of Hands Type sorted by score
        /// </summary>
        public enum HandCategory
        {
            None,
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
