using PNGPOKER.Common;
using PNGPOKER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal class ThreeOfAKindHandType : HandType
    {
        internal ThreeOfAKindHandType()
        {
            base.Name = "Three Of A Kind";
            base.HandCategories = Enums.HandCategory.ThreeOfAKind;
        }

        public override bool Validate(Cards cards)
        {
            return true;
        }
    }
}
