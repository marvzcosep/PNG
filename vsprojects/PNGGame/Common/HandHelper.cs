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
        /// <param name="cards"></param>
        /// <returns></returns>
        public static bool IsItStraightFlush(Cards cards)
        {
            return IsItStraight(cards) && IsItFlush(cards) ? true : false;
        }

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
        /// <param name="cards"></param>
        /// <returns></returns>
        public static bool IsItFullHouse(Cards cards)
        {
            return IsItOnePair(cards) && IsItThreeOfAKind(cards) ? true : false;
        }

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
        /// <param name="cards"></param>
        /// <returns></returns>
        public static bool IsItThreeOfAKind(Cards cards)
        {
            return cards.GroupBy(x => x.Rank).Where(y => y.Count() == 3).Any();
        }

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
        /// <param name="cards"></param>
        /// <returns></returns>
        public static bool IsItOnePair(Cards cards)
        {
            return cards.GroupBy(x => x.Rank).Where(y => y.Count() == 2).Count() == 1;
        }
    }
}
