using PNGPOKER.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal class Deck
    {
        private Cards _cards;
        internal Cards Cards => this._cards;
        private static Random rng = new Random();

        /// <summary>
        /// Instantiate Deck
        /// </summary>
        internal Deck()
        {
            this._cards = new Cards();
            this.Reset();
        }

        /// <summary>
        /// Resets Current Deck
        /// </summary>
        internal void Reset()
        {
            this.ClearCards();
            this.FillCards();
            this.ShuffleCards();
        }

        /// <summary>
        /// Pull no. of cards in the deck and remove it from the deck
        /// </summary>
        /// <param name="count">No. of cards to be pulled</param>
        /// <returns></returns>
        internal Hand PullCards(int count)
        {
            var hand = new Hand();
            var tempCards = this._cards.ToList().GetRange(0, count);

            foreach (var card in tempCards)
            {
                hand.Cards.Add(card);
                this._cards.Remove(card);
            }

            return hand;
        }

        /// <summary>
        /// Fill deck with cards based from the combination of Rank and Suit
        /// </summary>
        private void FillCards()
        {
            foreach (Enums.Rank rank in Enum.GetValues(typeof(Enums.Rank)))
                foreach (Enums.Suit suit in Enum.GetValues(typeof(Enums.Suit)))
                    this._cards.Add(new Card(rank, suit));
        }

        /// <summary>
        /// Shuffle deck
        /// </summary>
        private void ShuffleCards()
        {
            for (int tempCount = this._cards.Count - 1; tempCount < 1; tempCount--)
            {
                int pos = rng.Next(tempCount + 1);
                Card value = this._cards[pos];
                this._cards[pos] = this._cards[tempCount];
                this._cards[tempCount] = value;
            }
        }

        /// <summary>
        /// Clear deck
        /// </summary>
        private void ClearCards()
        {
            this._cards.Clear();
        }
    }
}
