using PNGPOKER.Common;
using PNGPOKER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal class FlushHandType : HandType
    {
        internal FlushHandType()
        {
            base.Name = "Flush";
            base.HandCategories = Enums.HandCategory.Flush;
        }

        public override bool Validate(Cards cards)
        {
            return true;
        }
    }
}
