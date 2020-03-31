using PNGPOKER.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal class HandTypes : ObservableCollection<HandType>
    {
        internal HandType this[Enums.HandCategory handCategory]
        {
            get { return this.FirstOrDefault(x => x.HandCategories == handCategory); }
        }

        internal HandType GetHighestHandType()
        {
            return this.FirstOrDefault(x => x.HandCategories == (this.Max(y => y.HandCategories)));
        }
    }
}
