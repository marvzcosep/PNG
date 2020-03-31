using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGPOKER.Model
{
    internal class Cards : ObservableCollection<Card>
    {
        internal Card this[string code]
        {
            get { return this.FirstOrDefault(x => x.Code == code); }
        }
    }
}
