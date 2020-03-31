using PNGPOKER.Common;
using PNGPOKER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal class FullHouseHandType : HandType
    {
        internal FullHouseHandType()
        {
            base.Name = "Full House";
            base.HandCategories = Enums.HandCategory.FullHouse;
        }

        public override bool Validate(Cards cards)
        {
            return true;
        }
    }
}
