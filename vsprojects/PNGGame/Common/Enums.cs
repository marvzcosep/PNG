namespace PNGGAME.Common
{
    public static class Enums
    {
        /// <summary>
        /// List of Suits
        /// </summary>
        public enum Suit
        {
            Hearts,
            Spades,
            Clubs,
            Diamonds
        }

        /// <summary>
        /// List of Rank sorted by score
        /// </summary>
        public enum Rank
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
