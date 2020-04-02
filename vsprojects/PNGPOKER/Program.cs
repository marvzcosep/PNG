using PNGGAME.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PNGPOKER
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = string.Empty;
            var pokerGame = new PokerGame();

            while (true)
            {
                Console.Clear();
                pokerGame.Reset();
                Console.WriteLine(string.Format("Let's play {0}!", pokerGame.Name));
                Console.WriteLine("\nFilling up the Deck...");
                Console.WriteLine("\nShuffling Cards...");
                Console.WriteLine(string.Format("\nInitial no. of cards in the deck: {0}", pokerGame.Deck.Cards.Count()));

                Console.WriteLine("\nInitializing Players...");
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

                Console.WriteLine("\nGame Start!!!");
                pokerGame.Start();

                Console.WriteLine("\nPlayers! Show Hand!\n");

                foreach (var player in pokerGame.Players)
                {
                    var cardCodeList = new List<string>();

                    foreach (var card in player.Hand.Cards)
                        cardCodeList.Add(card.Code);

                    Console.WriteLine(string.Format("{0}: {1} ({2})", player.Name, string.Join(", ", cardCodeList), player.Hand.HandCategory.ToString()));
                }

                Console.WriteLine("\nTotal remaining cards in the deck: " + pokerGame.Deck.Cards.Count());
                Console.WriteLine("\nEvaluating Winner(s)...");

                var winnerList = new List<string>();
                foreach (var winner in pokerGame.Winners)
                    winnerList.Add(winner.Name);

                Console.WriteLine(string.Format("\nWinner(s)!: {0} ({1})", string.Join(", ", winnerList).ToString(), pokerGame.WinnersHandCategory));
                Console.Write("\nDo you want to play again? (Y/N):");

                while (true)
                {
                    answer = Console.ReadLine();
                    if (answer.ToLower().Equals("y") || answer.ToLower().Equals("n"))
                        break;

                    Console.WriteLine("Error invalid entry");
                    Console.Write("\nDo you want to play again? (Y/N):");
                }

                if (answer.ToLower().Equals("n"))
                    break;
            }
        }
    }
}
