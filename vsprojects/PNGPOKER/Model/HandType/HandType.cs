using PNGPOKER.Common;
using PNGPOKER.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal abstract class HandType : IHandType
    {
        internal virtual string Name { get; set; }
        internal virtual Enums.HandCategory HandCategories { get; set; }

        public virtual bool Validate(Cards cards)
        {
            throw new NotImplementedException();
        }
    }
}
