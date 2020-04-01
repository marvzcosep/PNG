using PNGGAME.Common;
using PNGGAME.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Model
{
    public class TwoPairHandType : HandType
    {
        public TwoPairHandType()
        {
            base.Name = "Two Pair";
            base.HandCategories = Enums.HandCategory.TwoPair;
        }

        public override bool Validate(Cards cards)
        {
            return true;
        }
    }
}
