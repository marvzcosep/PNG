using PNGGAME.Common;
using PNGGAME.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Interface
{
    public interface IHandType
    {
        bool Validate(Cards cards);
    }
}
