using PNGGAME.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Model
{
    public class Hand
    {
        private Cards _cards;
        private Enums.HandCategory _handType;
        private int _cardsScore;
        private int _highestOutRankScore;
        public Cards Cards { get => this._cards; set => this._cards = value; }
        public Enums.HandCategory HandCategory => this._handType;
        public int CardsScore => this._cardsScore;
        public int HighestOutRankScore => this._highestOutRankScore;
        
        /// <summary>
        /// Hand Constructor
        /// </summary>
        public Hand()
        {
            this._cards = new Cards();
            this._cardsScore = 0;
            this._highestOutRankScore = 0;
            this._cards.CollectionChanged += Cards_CollectionChanged;
        }

        /// <summary>
        /// Will be fired when theres a changes in the list of card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cards_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if ((Cards)sender != null && ((Cards)sender).Count == 5)
                this.EvaluateHandType((Cards)sender);
        }

        /// <summary>
        /// Evaluates Hand Type of the Cards by demand
        /// </summary>
        public void EvaluateHandType()
        {
            this.EvaluateHandType(this._cards);
        }

        /// <summary>
        /// Evaluates Hand Type of the Cards
        /// </summary>
        /// <param name="cards"></param>
        private void EvaluateHandType(Cards cards)
        {
            if (HandHelper.IsItRoyalFlush(cards))
                this._handType = Enums.HandCategory.RoyalFlush;
            else if (HandHelper.IsItStraightFlush(cards))
                this._handType = Enums.HandCategory.StraightFlush;
            else if (HandHelper.IsItFourOfAKind(cards))
                this._handType = Enums.HandCategory.FourOfAKind;
            else if (HandHelper.IsItFullHouse(cards))
                this._handType = Enums.HandCategory.FullHouse;
            else if (HandHelper.IsItFlush(cards))
                this._handType = Enums.HandCategory.Flush;
            else if (HandHelper.IsItStraight(cards))
                this._handType = Enums.HandCategory.Straight;
            else if (HandHelper.IsItThreeOfAKind(cards))
                this._handType = Enums.HandCategory.ThreeOfAKind;
            else if (HandHelper.IsItTwoPair(cards))
                this._handType = Enums.HandCategory.TwoPair;
            else if (HandHelper.IsItOnePair(cards))
                this._handType = Enums.HandCategory.OnePair;
            else 
                this._handType = Enums.HandCategory.HighCard;

        } 
    }
}
