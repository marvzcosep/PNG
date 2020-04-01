using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGGAME.Model
{
    public class Cards : ObservableCollection<Card>
    {
        public Card this[string code]
        {
            get { return this.FirstOrDefault(x => x.Code == code); }
        }
    }
}
