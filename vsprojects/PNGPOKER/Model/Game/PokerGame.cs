using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal class PokerGame : IGame
    {
        private List<PokerPlayer> _players;
        private Deck _deck;
        public string Name => "Poker";
        public List<PokerPlayer> Players => this._players;
        public Deck Deck => this._deck;
        
        internal PokerGame()
        {
            this._players = new List<PokerPlayer>();
            this._deck = new Deck();
            this.Reset();
        }

        /// <summary>
        /// Resets Game
        /// </summary>
        public void Reset()
        {
            this.ClearPlayers();
            this._deck.Reset();
        }

        /// <summary>
        /// Start Game
        /// </summary>
        public void Start()
        {
            this.SetPlayersHand();
        }

        /// <summary>
        /// Set hand to all players
        /// </summary>
        private void SetPlayersHand()
        {
            foreach (var player in this._players)
                player.SetHand(this._deck.PullCards(5));
        }

        /// <summary>
        /// Add one player
        /// </summary>
        /// <param name="player"></param>
        public void AddPlayer(IPlayer player)
        {
            this._players.Add((PokerPlayer)player);
        }

        /// <summary>
        /// Add set of players
        /// </summary>
        /// <param name="players"></param>
        public void AddPlayers(List<IPlayer> players)
        {
            foreach (var player in players)
                this._players.Add((PokerPlayer)player);
        }

        /// <summary>
        /// Clear player list
        /// </summary>
        public void ClearPlayers()
        {
            this._players.Clear();
        }

        /// <summary>
        /// Get game winner(s)
        /// </summary>
        /// <returns></returns>
        public List<IPlayer> GetWinners()
        {
            throw new NotImplementedException();
        }
    }
}
