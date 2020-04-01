using PNGGAME.Common;
using PNGGAME.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Model
{
    public class ThreeOfAKindHandType : HandType
    {
        public ThreeOfAKindHandType()
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
