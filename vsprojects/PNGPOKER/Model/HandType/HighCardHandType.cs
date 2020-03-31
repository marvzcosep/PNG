using PNGPOKER.Common;
using PNGPOKER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal class HighCardHandType : HandType
    {
        internal HighCardHandType()
        {
            base.Name = "High Card";
            base.HandCategories = Enums.HandCategory.HighCard;
        }

        public override bool Validate(Cards cards)
        {
            return true;
        }
    }
}
