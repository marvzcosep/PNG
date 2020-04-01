using PNGGAME.Common;
using PNGGAME.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Model
{
    public class RoyalFlushHandType : HandType
    {
        public RoyalFlushHandType()
        {
            base.Name = "Royal Flush";
            base.HandCategories = Enums.HandCategory.RoyalFlush;
        }

        public override bool Validate(Cards cards)
        {
            return true;
        }
    }
}
