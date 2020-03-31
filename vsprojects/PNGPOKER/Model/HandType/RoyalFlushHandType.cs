using PNGPOKER.Common;
using PNGPOKER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal class RoyalFlushHandType : HandType
    {
        internal RoyalFlushHandType()
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
