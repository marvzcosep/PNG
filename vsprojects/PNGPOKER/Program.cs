using PNGGAME.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokerGame = new PokerGame();

            Console.WriteLine(string.Format("Initial no. of cards in the deck: {0}\n", pokerGame.Deck.Cards.Count()));

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

            foreach (var player in pokerGame.Players)
            {
                var cardCodeList = new List<string>();

                foreach (var card in player.Hand.Cards)
                    cardCodeList.Add(card.Code);

                Console.WriteLine(string.Format("{0}: {1} ({2})", player.Name, string.Join(", ", cardCodeList), player.Hand.HandCategory.ToString()));
            }

                Console.WriteLine("\nTotal remaining cards in the deck: " + pokerGame.Deck.Cards.Count());
            Console.ReadLine();
        }
    }
}
