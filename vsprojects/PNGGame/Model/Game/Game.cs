using PNGGAME.Interface;
using PNGGAME.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGame.Model.Game
{
    public abstract class Game : IGame
    {
        private string _name;

        public virtual string Name { get => this._name; set => this._name = value; }

        public virtual void AddPlayer(Player player)
        {
        }

        public virtual void AddPlayers(List<Player> players)
        {
        }

        public virtual void ClearPlayers()
        {
        }

        public virtual void Reset()
        {
        }

        public virtual void Start()
        {
        }
    }
}
