using PNGGame.Model.Game;
using PNGGAME.Common;
using System.Collections.Generic;

namespace PNGGAME.Model
{
    public class PokerGame : Game
    {
        private List<PokerPlayer> _players;
        private List<PokerPlayer> _winners;
        private Enums.HandCategory _winningHandCategory;
        private Deck _deck;

        public List<PokerPlayer> Players => this._players;
        public List<PokerPlayer> Winners => this._winners;
        public Enums.HandCategory WinnersHandCategory => this._winningHandCategory;
        public Deck Deck => this._deck;
        
        /// <summary>
        /// Poker Game Constructor
        /// </summary>
        public PokerGame()
        {
            base.Name = "Poker";
            this._players = new List<PokerPlayer>();
            this._winners = new List<PokerPlayer>();
            this._winningHandCategory = Enums.HandCategory.None;
            this._deck = new Deck();
            this.Reset();
        }

        /// <summary>
        /// Resets Game
        /// </summary>
        public override void Reset()
        {
            this.ClearPlayers();
            this._deck.Reset();
        }

        /// <summary>
        /// Start Game
        /// </summary>
        public override void Start()
        {
            this.SetPlayersHand();
            this.EvaluateWinners();
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
        public override void AddPlayer(Player player)
        {
            this._players.Add((PokerPlayer)player);
        }

        /// <summary>
        /// Add set of players
        /// </summary>
        /// <param name="players"></param>
        public override void AddPlayers(List<Player> players)
        {
            foreach (var player in players)
                this._players.Add((PokerPlayer)player);
        }

        /// <summary>
        /// Clear player list
        /// </summary>
        public override void ClearPlayers()
        {
            this._players.Clear();
        }

        /// <summary>
        /// Evaluate winner based on hand category
        /// </summary>
        private void EvaluateWinners()
        {
            this._winningHandCategory = HandHelper.GetWinningHandCategory(this._players);
            this._winners = HandHelper.EvaluateWinners(this._players, this._winningHandCategory);
        }
    }
}
