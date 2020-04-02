using PNGGAME.Model;
using System.Collections.Generic;

namespace PNGGAME.Interface
{
    public interface IGame
    {
        string Name { get; set; }
        void AddPlayer(Player player);
        void AddPlayers(List<Player> players);
        void ClearPlayers();
        void Start();
        void Reset();
    }
}
