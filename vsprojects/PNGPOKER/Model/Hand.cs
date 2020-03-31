using PNGPOKER.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal class Hand
    {
        private Cards _cards;        
        private HandType _handType;
        private HandTypes _handTypes;
        private int _cardsScore;
        internal Cards Cards { get => this._cards; set => this._cards = value; }
        internal HandType HandType => this._handType;
        internal int CardsScore => this._cardsScore;

        internal Hand()
        {
            this._cards = new Cards();
            this._cards.CollectionChanged += _cards_CollectionChanged;
        }

        private void _cards_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if ((Cards)sender != null)
                this.CheckHandType((Cards)sender);
        }

        private void CheckHandType(Cards cards)
        {
            var output = Helper.FindAllDerivedTypes<HandType>();
            foreach (var type in output)
            {
                type.GetMethod("Validate").Invoke(type, new object[] { cards });
            }

            //if (HandHelper.IsItRoyalFlush(cards, ref this._cardsScore))
            //    this._handType = Enums.HandCategory.RoyalFlush;
            //else if (HandHelper.IsItStraightFlush(cards, ref this._cardsScore))
            //    this._handType = Enums.HandCategory.StraightFlush;
            //else if (HandHelper.IsItFourOfAKind(cards, ref this._cardsScore))
            //    this._handType = Enums.HandCategory.FourOfAKind;
            //else if (HandHelper.IsItFullHouse(cards, ref this._cardsScore))
            //    this._handType = Enums.HandCategory.FullHouse;
            //else if (HandHelper.IsItRoyalFlush(cards, ref this._cardsScore))
            //    this._handType = Enums.HandCategory.RoyalFlush;
            //else if (HandHelper.IsItRoyalFlush(cards, ref this._cardsScore))
            //    this._handType = Enums.HandCategory.RoyalFlush;
            //else if (HandHelper.IsItRoyalFlush(cards, ref this._cardsScore))
            //    this._handType = Enums.HandCategory.RoyalFlush;
            //else if (HandHelper.IsItRoyalFlush(cards, ref this._cardsScore))
            //    this._handType = Enums.HandCategory.RoyalFlush;
            //else if (HandHelper.IsItRoyalFlush(cards, ref this._cardsScore))
            //    this._handType = Enums.HandCategory.RoyalFlush;
            //else if (HandHelper.IsItRoyalFlush(cards, ref this._cardsScore))
            //    this._handType = Enums.HandCategory.RoyalFlush;
            //else if (HandHelper.IsItRoyalFlush(cards, ref this._cardsScore))
            //    this._handType = Enums.HandCategory.RoyalFlush;
            //else if (HandHelper.IsItRoyalFlush(cards, ref this._cardsScore))
            //    this._handType = Enums.HandCategory.RoyalFlush;

        }
    }
}
