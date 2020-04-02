using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void RoyalFlush_EvaluateWinnersCount()
        {
            var players = new List<PokerPlayer>()
            {
                new PokerPlayer() { Name = "Marvz", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Two, Suit.Clover),
                                    new Card(Rank.King, Suit.Spades),
                                    new Card(Rank.Five, Suit.Diamonds),
                                    new Card(Rank.Jack, Suit.Clover),
                                    new Card(Rank.Ace, Suit.Hearts)} } },
                new PokerPlayer() { Name = "Keng", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Ace, Suit.Hearts),
                                    new Card(Rank.King, Suit.Hearts),
                                    new Card(Rank.Queen, Suit.Hearts),
                                    new Card(Rank.Jack, Suit.Hearts),
                                    new Card(Rank.Ten, Suit.Hearts)} } },
                new PokerPlayer() { Name = "Des", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Ace, Suit.Diamonds),
                                    new Card(Rank.King, Suit.Diamonds),
                                    new Card(Rank.Queen, Suit.Diamonds),
                                    new Card(Rank.Jack, Suit.Diamonds),
                                    new Card(Rank.Ten, Suit.Diamonds)} } }
            };

            foreach (var player in players)
                player.Hand.EvaluateHandType();

            var winners = HandHelper.EvaluateWinners(players, HandCategory.RoyalFlush);

            Assert.AreEqual(2, winners.Count);
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

        [TestMethod]
        public void StraightFlush_EvaluateWinnersCount()
        {
            var players = new List<PokerPlayer>()
            {
                new PokerPlayer() { Name = "Marvz", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Eight, Suit.Clover),
                                    new Card(Rank.Nine, Suit.Clover),
                                    new Card(Rank.Queen, Suit.Clover),
                                    new Card(Rank.Jack, Suit.Clover),
                                    new Card(Rank.Ten, Suit.Clover)} } },
                new PokerPlayer() { Name = "Keng", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Nine, Suit.Hearts),
                                    new Card(Rank.King, Suit.Hearts),
                                    new Card(Rank.Queen, Suit.Hearts),
                                    new Card(Rank.Jack, Suit.Hearts),
                                    new Card(Rank.Ten, Suit.Hearts)} } },
                new PokerPlayer() { Name = "Des", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Nine, Suit.Diamonds),
                                    new Card(Rank.King, Suit.Diamonds),
                                    new Card(Rank.Queen, Suit.Diamonds),
                                    new Card(Rank.Jack, Suit.Diamonds),
                                    new Card(Rank.Ten, Suit.Diamonds)} } }
            };

            foreach (var player in players)
                player.Hand.EvaluateHandType();

            var winners = HandHelper.EvaluateWinners(players, HandCategory.StraightFlush);

            Assert.AreEqual(2, winners.Count);
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

        [TestMethod]
        public void FourOfAKind_EvaluateWinnersCount()
        {
            var players = new List<PokerPlayer>()
            {
                new PokerPlayer() { Name = "Marvz", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.King, Suit.Diamonds),
                                    new Card(Rank.King, Suit.Hearts),
                                    new Card(Rank.King, Suit.Clover),
                                    new Card(Rank.King, Suit.Spades),
                                    new Card(Rank.Ace, Suit.Hearts)} } },
                new PokerPlayer() { Name = "Keng", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Ace, Suit.Diamonds),
                                    new Card(Rank.Ace, Suit.Hearts),
                                    new Card(Rank.Ace, Suit.Clover),
                                    new Card(Rank.Ace, Suit.Spades),
                                    new Card(Rank.Queen, Suit.Hearts)} } },
                new PokerPlayer() { Name = "Des", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Queen, Suit.Diamonds),
                                    new Card(Rank.Queen, Suit.Hearts),
                                    new Card(Rank.Queen, Suit.Clover),
                                    new Card(Rank.Queen, Suit.Spades),
                                    new Card(Rank.Jack, Suit.Hearts)} } }
            };

            foreach (var player in players)
                player.Hand.EvaluateHandType();

            var winners = HandHelper.EvaluateWinners(players, HandCategory.FourOfAKind);

            Assert.AreEqual(1, winners.Count);
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

        [TestMethod]
        public void FullHouse_EvaluateWinnersCount()
        {
            var players = new List<PokerPlayer>()
            {
                new PokerPlayer() { Name = "Marvz", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.King, Suit.Diamonds),
                                    new Card(Rank.King, Suit.Hearts),
                                    new Card(Rank.King, Suit.Clover),
                                    new Card(Rank.Ace, Suit.Spades),
                                    new Card(Rank.Ace, Suit.Hearts)} } },
                new PokerPlayer() { Name = "Keng", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Ace, Suit.Diamonds),
                                    new Card(Rank.Ace, Suit.Hearts),
                                    new Card(Rank.Ace, Suit.Clover),
                                    new Card(Rank.Queen, Suit.Spades),
                                    new Card(Rank.Queen, Suit.Hearts)} } },
                new PokerPlayer() { Name = "Des", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Queen, Suit.Diamonds),
                                    new Card(Rank.Queen, Suit.Hearts),
                                    new Card(Rank.Queen, Suit.Clover),
                                    new Card(Rank.Jack, Suit.Spades),
                                    new Card(Rank.Jack, Suit.Hearts)} } }
            };

            foreach (var player in players)
                player.Hand.EvaluateHandType();

            var winners = HandHelper.EvaluateWinners(players, HandCategory.FullHouse);

            Assert.AreEqual(1, winners.Count);
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

        [TestMethod]
        public void Flush_EvaluateWinnersCount()
        {
            var players = new List<PokerPlayer>()
            {
                new PokerPlayer() { Name = "Marvz", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Two, Suit.Spades),
                                    new Card(Rank.King, Suit.Spades),
                                    new Card(Rank.Five, Suit.Spades),
                                    new Card(Rank.Jack, Suit.Spades),
                                    new Card(Rank.Ace, Suit.Spades)} } },
                new PokerPlayer() { Name = "Keng", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Three, Suit.Hearts),
                                    new Card(Rank.King, Suit.Hearts),
                                    new Card(Rank.Five, Suit.Hearts),
                                    new Card(Rank.Jack, Suit.Hearts),
                                    new Card(Rank.Ace, Suit.Hearts)} } },
                new PokerPlayer() { Name = "Des", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Three, Suit.Diamonds),
                                    new Card(Rank.King, Suit.Diamonds),
                                    new Card(Rank.Five, Suit.Diamonds),
                                    new Card(Rank.Jack, Suit.Diamonds),
                                    new Card(Rank.Ace, Suit.Diamonds)} } }
            };

            foreach (var player in players)
                player.Hand.EvaluateHandType();

            var winners = HandHelper.EvaluateWinners(players, HandCategory.Flush);

            Assert.AreEqual(2, winners.Count);
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

        [TestMethod]
        public void Straight_EvaluateWinnersCount()
        {
            var players = new List<PokerPlayer>()
            {
                new PokerPlayer() { Name = "Marvz", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Eight, Suit.Hearts),
                                    new Card(Rank.Nine, Suit.Spades),
                                    new Card(Rank.Queen, Suit.Clover),
                                    new Card(Rank.Jack, Suit.Diamonds),
                                    new Card(Rank.Ten, Suit.Hearts)} } },
                new PokerPlayer() { Name = "Keng", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Nine, Suit.Spades),
                                    new Card(Rank.King, Suit.Clover),
                                    new Card(Rank.Queen, Suit.Diamonds),
                                    new Card(Rank.Jack, Suit.Hearts),
                                    new Card(Rank.Ten, Suit.Spades)} } },
                new PokerPlayer() { Name = "Des", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Nine, Suit.Clover),
                                    new Card(Rank.King, Suit.Diamonds),
                                    new Card(Rank.Queen, Suit.Hearts),
                                    new Card(Rank.Jack, Suit.Spades),
                                    new Card(Rank.Ten, Suit.Clover)} } }
            };

            foreach (var player in players)
                player.Hand.EvaluateHandType();

            var winners = HandHelper.EvaluateWinners(players, HandCategory.Straight);

            Assert.AreEqual(2, winners.Count);
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

        [TestMethod]
        public void ThreeOfAKind_EvaluateWinnersCount()
        {
            var players = new List<PokerPlayer>()
            {
                new PokerPlayer() { Name = "Marvz", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.King, Suit.Diamonds),
                                    new Card(Rank.King, Suit.Hearts),
                                    new Card(Rank.King, Suit.Clover),
                                    new Card(Rank.Ace, Suit.Spades),
                                    new Card(Rank.Two, Suit.Hearts)} } },
                new PokerPlayer() { Name = "Keng", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Ace, Suit.Diamonds),
                                    new Card(Rank.Ace, Suit.Hearts),
                                    new Card(Rank.Ace, Suit.Clover),
                                    new Card(Rank.Queen, Suit.Spades),
                                    new Card(Rank.King, Suit.Hearts)} } },
                new PokerPlayer() { Name = "Des", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Queen, Suit.Diamonds),
                                    new Card(Rank.Queen, Suit.Hearts),
                                    new Card(Rank.Queen, Suit.Clover),
                                    new Card(Rank.Eight, Suit.Spades),
                                    new Card(Rank.Jack, Suit.Hearts)} } }
            };

            foreach (var player in players)
                player.Hand.EvaluateHandType();

            var winners = HandHelper.EvaluateWinners(players, HandCategory.ThreeOfAKind);

            Assert.AreEqual(1, winners.Count);
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

        [TestMethod]
        public void TwoPair_EvaluateWinnersCount()
        {
            var players = new List<PokerPlayer>()
            {
                new PokerPlayer() { Name = "Marvz", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.King, Suit.Diamonds),
                                    new Card(Rank.King, Suit.Hearts),
                                    new Card(Rank.Ace, Suit.Clover),
                                    new Card(Rank.Ace, Suit.Spades),
                                    new Card(Rank.Six, Suit.Hearts)} } },
                new PokerPlayer() { Name = "Keng", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Ace, Suit.Diamonds),
                                    new Card(Rank.Ace, Suit.Hearts),
                                    new Card(Rank.King, Suit.Clover),
                                    new Card(Rank.Queen, Suit.Spades),
                                    new Card(Rank.King, Suit.Hearts)} } },
                new PokerPlayer() { Name = "Des", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Queen, Suit.Diamonds),
                                    new Card(Rank.Queen, Suit.Hearts),
                                    new Card(Rank.Jack, Suit.Clover),
                                    new Card(Rank.Eight, Suit.Spades),
                                    new Card(Rank.Jack, Suit.Hearts)} } }
            };

            foreach (var player in players)
                player.Hand.EvaluateHandType();

            var winners = HandHelper.EvaluateWinners(players, HandCategory.TwoPair);

            Assert.AreEqual(1, winners.Count);
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

        [TestMethod]
        public void OnePair_EvaluateWinnersCount()
        {
            var players = new List<PokerPlayer>()
            {
                new PokerPlayer() { Name = "Marvz", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Jack, Suit.Diamonds),
                                    new Card(Rank.King, Suit.Hearts),
                                    new Card(Rank.Ace, Suit.Clover),
                                    new Card(Rank.Ace, Suit.Spades),
                                    new Card(Rank.Six, Suit.Hearts)} } },
                new PokerPlayer() { Name = "Keng", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Ace, Suit.Diamonds),
                                    new Card(Rank.Ace, Suit.Hearts),
                                    new Card(Rank.King, Suit.Clover),
                                    new Card(Rank.Queen, Suit.Spades),
                                    new Card(Rank.Jack, Suit.Hearts)} } },
                new PokerPlayer() { Name = "Des", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Queen, Suit.Diamonds),
                                    new Card(Rank.Queen, Suit.Hearts),
                                    new Card(Rank.Jack, Suit.Clover),
                                    new Card(Rank.Eight, Suit.Spades),
                                    new Card(Rank.Five, Suit.Hearts)} } }
            };

            foreach (var player in players)
                player.Hand.EvaluateHandType();

            var winners = HandHelper.EvaluateWinners(players, HandCategory.OnePair);

            Assert.AreEqual(1, winners.Count);
        }
        #endregion

        #region High Card
        [TestMethod]
        public void HighCard_EvaluateWinnersCount()
        {
            var players = new List<PokerPlayer>()
            {
                new PokerPlayer() { Name = "Marvz", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Two, Suit.Clover),
                                    new Card(Rank.King, Suit.Spades),
                                    new Card(Rank.Five, Suit.Diamonds),
                                    new Card(Rank.Jack, Suit.Clover),
                                    new Card(Rank.Ace, Suit.Hearts)} } },
                new PokerPlayer() { Name = "Keng", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Three, Suit.Hearts),
                                    new Card(Rank.King, Suit.Clover),
                                    new Card(Rank.Five, Suit.Spades),
                                    new Card(Rank.Jack, Suit.Diamonds),
                                    new Card(Rank.Ace, Suit.Clover)} } },
                new PokerPlayer() { Name = "Des", Hand = new Hand() { Cards = new Cards{
                                    new Card(Rank.Three, Suit.Diamonds),
                                    new Card(Rank.King, Suit.Hearts),
                                    new Card(Rank.Five, Suit.Clover),
                                    new Card(Rank.Jack, Suit.Spades),
                                    new Card(Rank.Ace, Suit.Diamonds)} } }
            };

            foreach (var player in players)
                player.Hand.EvaluateHandType();

            var winners = HandHelper.EvaluateWinners(players, HandCategory.HighCard);

            Assert.AreEqual(2, winners.Count);
        }
        #endregion
    }
}
