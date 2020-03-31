using PNGPOKER.Common;
using PNGPOKER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal class OnePairHandType : HandType
    {
        internal OnePairHandType()
        {
            base.Name = "One Pair";
            base.HandCategories = Enums.HandCategory.OnePair;
        }

        public override bool Validate(Cards cards)
        {
            return true;
        }
    }
}
