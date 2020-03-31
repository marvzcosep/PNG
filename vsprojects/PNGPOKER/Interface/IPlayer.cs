using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Interface
{
    internal interface IPlayer
    {
        string Name { get; set; }
        int TotalScore { get; }
    }
}
