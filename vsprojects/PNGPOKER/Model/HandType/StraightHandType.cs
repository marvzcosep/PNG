using PNGPOKER.Common;
using PNGPOKER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal class StraightHandType : HandType
    {
        internal StraightHandType()
        {
            base.Name = "Straight";
            base.HandCategories = Enums.HandCategory.Straight;
        }

        public override bool Validate(Cards cards)
        {
            return true;
        }
    }
}
