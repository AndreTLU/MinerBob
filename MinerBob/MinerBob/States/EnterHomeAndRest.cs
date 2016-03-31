using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinerBob.Entities;
using MinerBob.Locations;

namespace MinerBob.States
{
    class EnterHomeAndRest : State
    {
        public EnterHomeAndRest(){}

        public override void Enter(Hunter hunter)
        {
            if (hunter.Location != Location.location_type.HOME) hunter.Location = Location.location_type.HOME;
        }

        public override void Execute(Hunter hunter)
        {
            hunter.rest();
            hunter.storeFood();
        }

        public override void Exit(Hunter hunter)
        {
            throw new NotImplementedException();
        }
    }
}
