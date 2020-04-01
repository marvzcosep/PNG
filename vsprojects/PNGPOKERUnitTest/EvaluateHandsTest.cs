using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PNGGAME.Common;
using PNGGAME.Model;
using static PNGGAME.Common.Enums;

namespace PNGPOKERUnitTest
{
    [TestClass]
    public class EvaluateHandsTest
    {
        #region Royal Flush
        [TestMethod]
        public void RoyalFlush_ShouldReturnTrue()
        {
            var cards = new Cards
            {
                new Card(Rank.Ace, Suit.Clover),
                new Card(Rank.King, Suit.Clover),
                new Card(Rank.Queen, Suit.Clover),
                new Card(Rank.Jack, Suit.Clover),
                new Card(Rank.Ten, Suit.Clover)
            };

            Assert.IsTrue(HandHelper.IsItRoyalFlush(cards));
        }

        [TestMethod]
        public void RoyalFlush_ShouldReturnFalse()
        {
            var cards = new Cards
            {
                new Card(Rank.Two, Suit.Clover),
                new Card(Rank.King, Suit.Spades),
                new Card(Rank.Five, Suit.Diamonds),
                new Card(Rank.Jack, Suit.Clover),
                new Card(Rank.Ace, Suit.Hearts)
            };

            Assert.IsFalse(HandHelper.IsItRoyalFlush(cards));
        }
        #endregion

        #region Straight Flush
        [TestMethod]
        public void StraightFlush_ShouldReturnTrue()
        {
            var cards = new Cards
            {
                new Card(Rank.Seven, Suit.Spades),
                new Card(Rank.Four, Suit.Spades),
                new Card(Rank.Five, Suit.Spades),
                new Card(Rank.Six, Suit.Spades),
                new Card(Rank.Three, Suit.Spades)
            };

            Assert.IsTrue(HandHelper.IsItStraightFlush(cards));
        }

        [TestMethod]
        public void StraightFlush_ShouldReturnFalse()
        {
            var cards = new Cards
            {
                new Card(Rank.Two, Suit.Clover),
                new Card(Rank.King, Suit.Spades),
                new Card(Rank.Five, Suit.Diamonds),
                new Card(Rank.Jack, Suit.Clover),
                new Card(Rank.Ace, Suit.Hearts)
            };

            Assert.IsFalse(HandHelper.IsItStraightFlush(cards));
        }
        #endregion

        #region Four Of A Kind
        [TestMethod]
        public void FourOfAKind_ShouldReturnTrue()
        {
            var cards = new Cards
            {
                new Card(Rank.Seven, Suit.Clover),
                new Card(Rank.Four, Suit.Spades),
                new Card(Rank.Four, Suit.Diamonds),
                new Card(Rank.Four, Suit.Clover),
                new Card(Rank.Four, Suit.Hearts)
            };

            Assert.IsTrue(HandHelper.IsItFourOfAKind(cards));
        }

        [TestMethod]
        public void FourOfAKind_ShouldReturnFalse()
        {
            var cards = new Cards
            {
                new Card(Rank.Two, Suit.Clover),
                new Card(Rank.King, Suit.Spades),
                new Card(Rank.Five, Suit.Diamonds),
                new Card(Rank.Jack, Suit.Clover),
                new Card(Rank.Ace, Suit.Hearts)
            };

            Assert.IsFalse(HandHelper.IsItFourOfAKind(cards));
        }
        #endregion

        #region Full House
        [TestMethod]
        public void FullHouse_ShouldReturnTrue()
        {
            var cards = new Cards
            {
                new Card(Rank.Two, Suit.Clover),
                new Card(Rank.Four, Suit.Spades),
                new Card(Rank.Two, Suit.Diamonds),
                new Card(Rank.Four, Suit.Hearts),
                new Card(Rank.Four, Suit.Clover)
            };

            Assert.IsTrue(HandHelper.IsItFullHouse(cards));
        }

        [TestMethod]
        public void FullHouse_ShouldReturnFalse()
        {
            var cards = new Cards
            {
                new Card(Rank.Two, Suit.Clover),
                new Card(Rank.King, Suit.Spades),
                new Card(Rank.Five, Suit.Diamonds),
                new Card(Rank.Jack, Suit.Clover),
                new Card(Rank.Ace, Suit.Hearts)
            };

            Assert.IsFalse(HandHelper.IsItFullHouse(cards));
        }
        #endregion

        #region Flush
        [TestMethod]
        public void Flush_ShouldReturnTrue()
        {
            var cards = new Cards
            {
                new Card(Rank.Seven, Suit.Clover),
                new Card(Rank.King, Suit.Clover),
                new Card(Rank.Eight, Suit.Clover),
                new Card(Rank.Two, Suit.Clover),
                new Card(Rank.Ten, Suit.Clover)
            };

            Assert.IsTrue(HandHelper.IsItFlush(cards));
        }

        [TestMethod]
        public void Flush_ShouldReturnFalse()
        {
            var cards = new Cards
            {
                new Card(Rank.Two, Suit.Clover),
                new Card(Rank.King, Suit.Spades),
                new Card(Rank.Five, Suit.Diamonds),
                new Card(Rank.Jack, Suit.Clover),
                new Card(Rank.Ace, Suit.Hearts)
            };

            Assert.IsFalse(HandHelper.IsItFlush(cards));
        }
        #endregion

        #region Straight
        [TestMethod]
        public void Straight_ShouldReturnTrue()
        {
            var cards = new Cards
            {
                new Card(Rank.Nine, Suit.Clover),
                new Card(Rank.Seven, Suit.Spades),
                new Card(Rank.Ten, Suit.Diamonds),
                new Card(Rank.Eight, Suit.Clover),
                new Card(Rank.Six, Suit.Hearts)
            };

            Assert.IsTrue(HandHelper.IsItStraight(cards));
        }

        [TestMethod]
        public void Straight_ShouldReturnFalse()
        {
            var cards = new Cards
            {
                new Card(Rank.Two, Suit.Clover),
                new Card(Rank.King, Suit.Spades),
                new Card(Rank.Five, Suit.Diamonds),
                new Card(Rank.Jack, Suit.Clover),
                new Card(Rank.Ace, Suit.Hearts)
            };

            Assert.IsFalse(HandHelper.IsItStraight(cards));
        }
        #endregion

        #region Three Of A Kind
        [TestMethod]
        public void ThreeOfAKind_ShouldReturnTrue()
        {
            var cards = new Cards
            {
                new Card(Rank.Eight, Suit.Clover),
                new Card(Rank.King, Suit.Spades),
                new Card(Rank.Eight, Suit.Diamonds),
                new Card(Rank.Jack, Suit.Clover),
                new Card(Rank.Eight, Suit.Hearts)
            };

            Assert.IsTrue(HandHelper.IsItThreeOfAKind(cards));
        }

        [TestMethod]
        public void ThreeOfAKind_ShouldReturnFalse()
        {
            var cards = new Cards
            {
                new Card(Rank.Two, Suit.Clover),
                new Card(Rank.King, Suit.Spades),
                new Card(Rank.Five, Suit.Diamonds),
                new Card(Rank.Jack, Suit.Clover),
                new Card(Rank.Ace, Suit.Hearts)
            };

            Assert.IsFalse(HandHelper.IsItThreeOfAKind(cards));
        }
        #endregion

        #region Two Pair
        [TestMethod]
        public void TwoPair_ShouldReturnTrue()
        {
            var cards = new Cards
            {
                new Card(Rank.Six, Suit.Clover),
                new Card(Rank.Nine, Suit.Spades),
                new Card(Rank.Ace, Suit.Diamonds),
                new Card(Rank.Nine, Suit.Clover),
                new Card(Rank.Ace, Suit.Hearts)
            };

            Assert.IsTrue(HandHelper.IsItTwoPair(cards));
        }

        [TestMethod]
        public void TwoPair_ShouldReturnFalse()
        {
            var cards = new Cards
            {
                new Card(Rank.Two, Suit.Clover),
                new Card(Rank.King, Suit.Spades),
                new Card(Rank.Five, Suit.Diamonds),
                new Card(Rank.Jack, Suit.Clover),
                new Card(Rank.Ace, Suit.Hearts)
            };

            Assert.IsFalse(HandHelper.IsItTwoPair(cards));
        }
        #endregion

        #region One Pair
        [TestMethod]
        public void OnePair_ShouldReturnTrue()
        {
            var cards = new Cards
            {
                new Card(Rank.Six, Suit.Clover),
                new Card(Rank.Nine, Suit.Spades),
                new Card(Rank.King, Suit.Diamonds),
                new Card(Rank.Nine, Suit.Clover),
                new Card(Rank.Ace, Suit.Hearts)
            };

            Assert.IsTrue(HandHelper.IsItOnePair(cards));
        }

        [TestMethod]
        public void OnePair_ShouldReturnFalse()
        {
            var cards = new Cards
            {
                new Card(Rank.Two, Suit.Clover),
                new Card(Rank.King, Suit.Spades),
                new Card(Rank.Five, Suit.Diamonds),
                new Card(Rank.Jack, Suit.Clover),
                new Card(Rank.Ace, Suit.Hearts)
            };

            Assert.IsFalse(HandHelper.IsItOnePair(cards));
        }
        #endregion
    }
}
