using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinerBob.Entities;
using MinerBob.Locations;

namespace MinerBob.States
{
    class EnterForestAndHuntFood : State<Hunter>
    {
        private static EnterForestAndHuntFood instance;
        private EnterForestAndHuntFood(){}

        public static EnterForestAndHuntFood Instance
        {
            get
            {
                if (instance == null) instance = new EnterForestAndHuntFood();
                return instance;
            }
        }
        public override void Enter(Hunter hunter)
        {
            if(hunter.Location != Location.location_type.FOREST)
            {
                hunter.Location = Location.location_type.FOREST;
                Console.WriteLine(hunter.Name + " - Entering Forest ");
            }
            
        }

        public override void Execute(Hunter hunter)
        {
            Console.WriteLine(hunter.Name + " - Gathering some food... ");
   
            hunter.IncreaseFatigue(1);
            hunter.addFood(1);
            //if (hunter.NeedRest()) hunter.changeState(EnterHomeAndRest.Instance);
            if (hunter.Thirst > 8) hunter.GetSM().changeState(QuenchThirst.Instance);
            if (hunter.PocketsFull()) hunter.GetSM().changeState(StoreTheFood.Instance);
        }

        public override void Exit(Hunter hunter)
        {
            Console.WriteLine(hunter.Name + " - Leaving Forest ");
        }
    }
}
