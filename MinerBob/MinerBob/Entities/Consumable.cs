using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerBob.Entities
{
    class Consumable: BaseItem
    {
        int _charges;
        int _restore;

        public int Charges
        {
            get { return _charges; }
            set { _charges = value; }
        }
        public int Restore
        {
            get { return _restore; }
            protected set { _restore = value; }
        }

        public Consumable(string name, string desc, int value, int charges, int restore): base(name, desc, value)
        {
            this.Charges = charges;
            this.Restore = restore;
        }
    }
}
