using PNGGAME.Common;
using PNGGAME.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Model
{
    public class StraightHandType : HandType
    {
        public StraightHandType()
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
