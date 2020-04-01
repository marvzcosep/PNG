using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Interface
{
    public interface IPlayer
    {
        string Name { get; set; }
        int TotalScore { get; set; }
    }
}
