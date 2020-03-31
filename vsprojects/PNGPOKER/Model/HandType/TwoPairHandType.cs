using PNGPOKER.Common;
using PNGPOKER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal class TwoPairHandType : HandType
    {
        internal TwoPairHandType()
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
