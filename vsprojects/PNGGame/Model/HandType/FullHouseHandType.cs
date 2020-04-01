using PNGGAME.Common;
using PNGGAME.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Model
{
    public class FullHouseHandType : HandType
    {
        public FullHouseHandType()
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
