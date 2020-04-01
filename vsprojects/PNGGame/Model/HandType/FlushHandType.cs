using PNGGAME.Common;
using PNGGAME.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Model
{
    public class FlushHandType : HandType
    {
        public FlushHandType()
        {
            base.Name = "Flush";
            base.HandCategories = Enums.HandCategory.Flush;
        }

        public override bool Validate(Cards cards)
        {
            return true;
        }
    }
}
