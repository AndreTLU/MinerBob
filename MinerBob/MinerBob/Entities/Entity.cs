using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinerBob.Locations;

namespace MinerBob.Entities
{
    class Entity
    {
        int _id;
        static int _netxtValidID;
        Location.location_type _location;

        virtual public Location.location_type Location
        {
            get { return _location; }
            set { _location = value; }
        }

        void setID()
        {
            _id = _netxtValidID;
        }

        public Entity()
        {
            setID();
        }
        virtual public void Update()
        {

        }
    }
}
