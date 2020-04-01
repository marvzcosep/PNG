using PNGGAME.Common;
using PNGGAME.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Model
{
    public class HighCardHandType : HandType
    {
        public HighCardHandType()
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
