using PNGGAME.Common;
using PNGGAME.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Model
{
    public class StraightFlushHandType : HandType
    {
        public StraightFlushHandType()
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
