using PNGGAME.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Common
{
    public static class HandHelper
    {
        #region Common
        /// <summary>
        /// 
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        public static Enums.HandCategory GetWinningHandCategory(List<PokerPlayer> players)
        {
            Enums.HandCategory winningHandCategory = new Enums.HandCategory();

            for (int i = 0; i < players.Count; i++)
            {
                if (i == 0)
                    winningHandCategory = players[i].Hand.HandCategory;
                else
                {
                    if((int)players[i].Hand.HandCategory > (int)winningHandCategory)
                        winningHandCategory = players[i].Hand.HandCategory;
                }
            }

            return Enums.HandCategory.Flush;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="players"></param>
        /// <param name="winningHandCategory"></param>
        /// <returns></returns>
        public static List<PokerPlayer> GetAllPlayersWithWinningHandCategory(List<PokerPlayer> players, Enums.HandCategory winningHandCategory)
        {
            var results = new List<PokerPlayer>();

            foreach (var player in players)
                if (player.Hand.HandCategory.Equals(winningHandCategory))
                    results.Add(player);

            return results;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="players"></param>
        /// <param name="winningHandCategory"></param>
        /// <returns></returns>
        public static List<PokerPlayer> EvaluateWinners(List<PokerPlayer> players, Enums.HandCategory winningHandCategory)
        {
            var results = new List<PokerPlayer>();

            switch (winningHandCategory)
            {
                case Enums.HandCategory.RoyalFlush:
                    results = EvaluateRoyalFlushWinners(players);
                    break;
                case Enums.HandCategory.StraightFlush:
                    results = EvaluateStraightFlushWinners(players);
                    break;
                case Enums.HandCategory.FourOfAKind:
                    results = EvaluateFourOfAKindWinners(players);
                    break;
                case Enums.HandCategory.FullHouse:
                    results = EvaluateFullHouseWinners(players);
                    break;
                case Enums.HandCategory.Flush:
                    results = EvaluateFlushWinners(players);
                    break;
                case Enums.HandCategory.Straight:
                    results = EvaluateStraightWinners(players);
                    break;
                case Enums.HandCategory.ThreeOfAKind:
                    results = EvaluateThreeOfAKindWinners(players);
                    break;
                case Enums.HandCategory.TwoPair:
                    results = EvaluateTwoPairWinners(players);
                    break;
                case Enums.HandCategory.OnePair:
                    results = EvaluateOnePairWinners(players);
                    break;
                case Enums.HandCategory.HighCard:
                    results = EvaluateHighCardWinners(players);
                    break;
                case Enums.HandCategory.None:
                default:
                    break;
            }

            return results;
        }
        #endregion

        #region Royal Flush
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static bool IsItRoyalFlush(Cards cards)
        {
            return IsItStraight(cards) &&
                   IsItFlush(cards) &&
                   (cards.Where(x => x.Rank == Enums.Rank.Ace ||
                                      x.Rank == Enums.Rank.King).Count() == 2) ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        internal static List<PokerPlayer> EvaluateRoyalFlushWinners(List<PokerPlayer> players)
        {
            return players;
        }
        #endregion

        #region Straight Flush
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static bool IsItStraightFlush(Cards cards)
        {
            return IsItStraight(cards) && IsItFlush(cards) ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        internal static List<PokerPlayer> EvaluateStraightFlushWinners(List<PokerPlayer> players)
        {
            var results = new List<PokerPlayer>();

            var highestRank = Enums.Rank.Two;

            foreach (var player in players)
            {
                var tempRank = (player.Hand.Cards.OrderBy(x => x.Rank).ToArray()).Last().Rank;

                if (((int)tempRank > (int)highestRank && highestRank != Enums.Rank.Ace) || tempRank.Equals(Enums.Rank.Ace))
                    highestRank = tempRank;
            }

            foreach (var player in players)
            {
                var tempRank = (player.Hand.Cards.OrderBy(x => x.Rank).ToArray()).Last().Rank;

                if (tempRank.Equals(highestRank))
                    results.Add(player);
            }

            return results;
        }
        #endregion

        #region Four Of A Kind
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static bool IsItFourOfAKind(Cards cards)
        {
            return cards.GroupBy(x => x.Rank).Where(y => y.Count() == 4).Any();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        internal static List<PokerPlayer> EvaluateFourOfAKindWinners(List<PokerPlayer> players)
        {
            var results = new List<PokerPlayer>();


            return results;
        }
        #endregion

        #region Full House
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static bool IsItFullHouse(Cards cards)
        {
            return IsItOnePair(cards) && IsItThreeOfAKind(cards) ? true : false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        internal static List<PokerPlayer> EvaluateFullHouseWinners(List<PokerPlayer> players)
        {
            var results = new List<PokerPlayer>();
            return results;
        }
        #endregion

        #region Flush
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static bool IsItFlush(Cards cards)
        {
            return cards.GroupBy(x => x.Suit).Count() == 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        internal static List<PokerPlayer> EvaluateFlushWinners(List<PokerPlayer> players)
        {
            var results = new List<PokerPlayer>();


            return results;
        }
        #endregion

        #region Straight
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static bool IsItStraight(Cards cards)
        {
            var result = true;
            if (cards.Where(x => x.Rank == Enums.Rank.Ace ||
                             x.Rank == Enums.Rank.King ||
                             x.Rank == Enums.Rank.Queen ||
                             x.Rank == Enums.Rank.Jack ||
                             x.Rank == Enums.Rank.Ten).Count() == 5)

            {
                result = true;
            }
            else
            {
                var ordered = cards.OrderBy(x => x.Rank).ToArray();
                var straightStart = (int)ordered.First().Rank;
                for (var i = 1; i < ordered.Length; i++)
                {
                    if ((int)ordered[i].Rank != straightStart + i)
                        result = false;
                }
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        internal static List<PokerPlayer> EvaluateStraightWinners(List<PokerPlayer> players)
        {
            var results = new List<PokerPlayer>();

            var highestRank = Enums.Rank.Two;

            foreach (var player in players)
            {
                var tempRank = (player.Hand.Cards.OrderBy(x => x.Rank).ToArray()).Last().Rank;

                if (((int)tempRank > (int)highestRank && highestRank != Enums.Rank.Ace) || tempRank.Equals(Enums.Rank.Ace))
                    highestRank = tempRank;
            }

            foreach (var player in players)
            {
                var tempRank = (player.Hand.Cards.OrderBy(x => x.Rank).ToArray()).Last().Rank;

                if (tempRank.Equals(highestRank))
                    results.Add(player);
            }

            return results;
        }
        #endregion

        #region Three Of A Kind
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static bool IsItThreeOfAKind(Cards cards)
        {
            return cards.GroupBy(x => x.Rank).Where(y => y.Count() == 3).Any();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        internal static List<PokerPlayer> EvaluateThreeOfAKindWinners(List<PokerPlayer> players)
        {
            var results = new List<PokerPlayer>();
            return results;
        }
        #endregion

        #region Two Pair
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static bool IsItTwoPair(Cards cards)
        {
            return cards.GroupBy(x => x.Rank).Where(y => y.Count() == 2).Count() == 2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        internal static List<PokerPlayer> EvaluateTwoPairWinners(List<PokerPlayer> players)
        {
            var results = new List<PokerPlayer>();
            return results;
        }
        #endregion

        #region One Pair
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static bool IsItOnePair(Cards cards)
        {
            return cards.GroupBy(x => x.Rank).Where(y => y.Count() == 2).Count() == 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        internal static List<PokerPlayer> EvaluateOnePairWinners(List<PokerPlayer> players)
        {
            var results = new List<PokerPlayer>();
            return results;
        }
        #endregion

        #region High Card
        /// <summary>
        /// 
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        internal static List<PokerPlayer> EvaluateHighCardWinners(List<PokerPlayer> players)
        {
            var results = new List<PokerPlayer>();
            return results;
        }
        #endregion
    }
}
