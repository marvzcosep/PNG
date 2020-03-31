using PNGPOKER.Common;
using PNGPOKER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal class FourOfAKindHandType : HandType
    {
        internal FourOfAKindHandType()
        {
            base.Name = "Four Of A Kind";
            base.HandCategories = Enums.HandCategory.FourOfAKind;
        }

        public override bool Validate(Cards cards)
        {
            return true;
        }
    }
}
