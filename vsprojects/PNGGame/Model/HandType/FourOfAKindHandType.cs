using PNGGAME.Common;
using PNGGAME.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Model
{
    public class FourOfAKindHandType : HandType
    {
        public FourOfAKindHandType()
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
