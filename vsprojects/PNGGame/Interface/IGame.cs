using PNGGAME.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Interface
{
    public interface IGame
    {
        string Name { get; }
        void AddPlayer(Player player);
        void AddPlayers(List<Player> players);
        void ClearPlayers();
        void Start();
        void Reset();
        List<Player> GetWinners();
    }
}
