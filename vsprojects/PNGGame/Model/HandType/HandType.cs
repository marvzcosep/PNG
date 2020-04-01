using PNGGAME.Common;
using PNGGAME.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Model
{
    public abstract class HandType : IHandType
    {
        public virtual string Name { get; set; }
        public virtual Enums.HandCategory HandCategories { get; set; }

        public virtual bool Validate(Cards cards)
        {
            throw new NotImplementedException();
        }
    }
}
