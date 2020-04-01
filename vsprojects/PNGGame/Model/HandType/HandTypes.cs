using PNGGAME.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Model
{
    public class HandTypes : ObservableCollection<HandType>
    {
        public HandType this[Enums.HandCategory handCategory]
        {
            get { return this.FirstOrDefault(x => x.HandCategories == handCategory); }
        }

        public HandType GetHighestHandType()
        {
            return this.FirstOrDefault(x => x.HandCategories == (this.Max(y => y.HandCategories)));
        }
    }
}
