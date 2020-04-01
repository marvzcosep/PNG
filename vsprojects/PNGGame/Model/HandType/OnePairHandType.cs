using PNGGAME.Common;
using PNGGAME.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Model
{
    public class OnePairHandType : HandType
    {
        public OnePairHandType()
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
