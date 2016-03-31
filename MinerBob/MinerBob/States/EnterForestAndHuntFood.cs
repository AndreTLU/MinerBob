using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinerBob.Entities;
using MinerBob.Locations;

namespace MinerBob.States
{
    class EnterForestAndHuntFood : State
    {
        public EnterForestAndHuntFood()
        {

        }

        public override void Enter(Hunter hunter)
        {
            if(hunter.Location != Location.location_type.FOREST)
            {
                hunter.Location = Location.location_type.FOREST;
            }
        }

        public override void Execute(Hunter hunter)
        {
            hunter.addFood(1);
            if (hunter.PocketsFull()) hunter.changeState(EnterHomeAndRest);
        }

        public override void Exit(Hunter hunter)
        {
            throw new NotImplementedException();
        }
    }
}
