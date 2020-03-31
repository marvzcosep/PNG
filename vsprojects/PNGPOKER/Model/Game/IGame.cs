using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal interface IGame
    {
        string Name { get; }
        void AddPlayer(IPlayer player);
        void AddPlayers(List<IPlayer> players);
        void ClearPlayers();
        void Start();
        void Reset();
        List<IPlayer> GetWinners();
    }
}
