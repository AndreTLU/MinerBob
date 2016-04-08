using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerBob.Entities
{
    public abstract class BaseItem
    {
        string  _name;
        string  _description;
        int     _price;

        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }
        public int Price
        {
            get { return _price; }
            protected set { _price = value; }
        }
        public string Desc
        {
            get { return _description; }
            protected set { _description = value; }
        }


        public BaseItem(string name, string desc, int value)
        {
            this.Name = name;
            this.Desc = desc;
            this.Price = value;
        }

        
    }
}
