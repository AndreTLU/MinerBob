using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinerBob.Entities;
using MinerBob.Locations;
using System.Threading;

namespace MinerBob.States
{
    class EnterHomeAndRest : State
    {
        private static EnterHomeAndRest instance;
        private EnterHomeAndRest() { }

        public static EnterHomeAndRest Instance
        {
            get
            {
                if (instance == null) instance = new EnterHomeAndRest();
                return instance;
            }
        }

        public override void Enter(Hunter hunter)
        {
            if (hunter.Location != Location.location_type.HOME)
            {
                hunter.Location = Location.location_type.HOME;
                Console.WriteLine("Going home ");
            }
            
        }

        public override void Execute(Hunter hunter)
        {

            hunter.rest();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("[" + hunter.Location.ToString() + "] Resting for a bit .... ");
                Thread.Sleep(1000);
            }
            hunter.changeState(EnterForestAndHuntFood.Instance);
        }

        public override void Exit(Hunter hunter)
        {
            Console.WriteLine("Leaving home ");
        }
    }
}
