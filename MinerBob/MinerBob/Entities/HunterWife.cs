using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinerBob.Locations;
using MinerBob.States;

namespace MinerBob.Entities
{
    class HunterWife : Entity
    {
        string _name;

        StateMachine<HunterWife> _StateMachine;

        Location.location_type _location;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public Location.location_type Location
        {
            get { return _location; }
            set { _location = value; }
        }


        public HunterWife(string _text)
        {
            Name = _text;
            _StateMachine = new StateMachine<HunterWife>(this);
            _location = Locations.Location.location_type.HOME;

        }

        public override void Update()
        {
            _StateMachine.Update();
        }

        public StateMachine<HunterWife> GetSM()
        {
            return _StateMachine;
        }
    }
}
