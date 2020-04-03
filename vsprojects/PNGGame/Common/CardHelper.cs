using PNGGAME.Model;
using System.Linq;

namespace PNGGAME.Common
{
    public static class CardHelper
    {
        /// <summary>
        /// Generate Card Code
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public static string GetCardCode(Card card)
        {
            return GetRankCode(card.Rank) + GetSuitCode(card.Suit);
        }

        /// <summary>
        /// Generate Rank Code
        /// </summary>
        /// <param name="rank"></param>
        /// <returns></returns>
        private static string GetRankCode(Enums.Rank rank)
        {
            var result = string.Empty;

            switch (rank)
            {
                case Enums.Rank.Two:
                    result = "2";
                    break;
                case Enums.Rank.Three:
                    result = "3";
                    break;
                case Enums.Rank.Four:
                    result = "4";
                    break;
                case Enums.Rank.Five:
                    result = "5";
                    break;
                case Enums.Rank.Six:
                    result = "6";
                    break;
                case Enums.Rank.Seven:
                    result = "7";
                    break;
                case Enums.Rank.Eight:
                    result = "8";
                    break;
                case Enums.Rank.Nine:
                    result = "9";
                    break;
                case Enums.Rank.Ten:
                    result = "10";
                    break;
                case Enums.Rank.Jack:
                    result = "J";
                    break;
                case Enums.Rank.Queen:
                    result = "Q";
                    break;
                case Enums.Rank.King:
                    result = "K";
                    break;
                case Enums.Rank.Ace:
                    result = "A";
                    break;
            }

            return result;
        }

        /// <summary>
        /// Generate Suit Code
        /// </summary>
        /// <param name="suit"></param>
        /// <returns></returns>
        private static string GetSuitCode(Enums.Suit suit)
        {
            var result = string.Empty;

            switch (suit)
            {
                case Enums.Suit.Clubs:
                    result = "C";
                    break;
                case Enums.Suit.Diamonds:
                    result = "D";
                    break;
                case Enums.Suit.Hearts:
                    result = "H";
                    break;
                case Enums.Suit.Spades:
                    result = "S";
                    break;
            }

            return result;
        }

        /// <summary>
        /// Add 13 score per Ace since Ace will be treated as 0
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static int CheckIfAceExists(Cards cards)
        {
            var count = cards.Select(x => x.Rank == Enums.Rank.Ace).Count();
            return count > 0 ? count * 13 : 0;
        }
    }
}
