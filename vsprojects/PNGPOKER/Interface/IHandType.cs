using PNGPOKER.Common;
using PNGPOKER.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Interface
{
    internal interface IHandType
    {
        bool Validate(Cards cards);
    }
}
