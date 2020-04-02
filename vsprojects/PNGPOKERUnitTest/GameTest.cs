using Microsoft.VisualStudio.TestTools.UnitTesting;
using PNGGAME.Model;
using System.Collections.Generic;

namespace PNGPOKERUnitTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void PokerGame_ShouldAutoCreateDesk()
        {
            var pokerGame = new PokerGame();

            Assert.IsNotNull(pokerGame.Deck);
        }

        [TestMethod]
        public void PokerGame_DeckShouldHave52Cards()
        {
            var pokerGame = new PokerGame();

            Assert.AreEqual(52, pokerGame.Deck.Cards.Count);
        }

        [TestMethod]
        public void PokerGame_CheckingCardsInDeckPerPull()
        {
            var pokerGame = new PokerGame();

            var players = new List<PokerPlayer>()
            {
                new PokerPlayer() { Name = "Marvz" },
                new PokerPlayer() { Name = "Keng" },
                new PokerPlayer() { Name = "Des" },
                new PokerPlayer() { Name = "Joel" },
                new PokerPlayer() { Name = "Wash" }
            };

            foreach (var player in players)
                pokerGame.AddPlayer(player);

            pokerGame.Start();

            int expectedRemainingCards = 52 - (players.Count * 5);

            Assert.AreEqual(expectedRemainingCards, pokerGame.Deck.Cards.Count);
        }
    }
}
