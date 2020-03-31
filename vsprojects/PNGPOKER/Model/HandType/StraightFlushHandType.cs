using PNGPOKER.Common;
using PNGPOKER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal class StraightFlushHandType : HandType
    {
        internal StraightFlushHandType()
        {
            base.Name = "Straight Flush";
            base.HandCategories = Enums.HandCategory.StraightFlush;
        }

        public override bool Validate(Cards cards)
        {
            return true;
        }
    }
}
