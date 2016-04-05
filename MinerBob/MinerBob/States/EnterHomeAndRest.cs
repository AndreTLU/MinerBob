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
    class EnterHomeAndRest : State<Hunter>
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
                Console.WriteLine(hunter.Name + " - Going home ");
            }
            
        }

        public override void Execute(Hunter hunter)
        {
            if(hunter.Fatigue > 0)
            {
                hunter.rest();
                for (int i = hunter.Fatigue; i > 0; i--)
                {
                    Console.WriteLine(hunter.Name + " - Resting for a bit .... ");
                    Thread.Sleep(1000);
                }
            }
            else
            {
                Console.WriteLine(hunter.Name + " - Grabbing a snack");
                Console.WriteLine(hunter.Name + " - Going back to my work");
                hunter.GetSM().changeState(EnterForestAndHuntFood.Instance);
            }
            
        }

        public override void Exit(Hunter hunter)
        {
            Console.WriteLine(hunter.Name + " - Leaving home ");
        }
    }
}
