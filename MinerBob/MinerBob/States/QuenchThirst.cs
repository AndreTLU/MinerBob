using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinerBob.Entities;

namespace MinerBob.States
{
    class QuenchThirst : State
    {
        private static QuenchThirst instance;
        private QuenchThirst() { }

        public static QuenchThirst Instance
        {
            get
            {
                if (instance == null) instance = new QuenchThirst();
                return instance;
            }
        }

        public override void Enter(Hunter hunter)
        {
            if(hunter.Location != Locations.Location.location_type.RIVER)
            {
                hunter.Location = Locations.Location.location_type.RIVER;
                Console.WriteLine(hunter.Name + " - Man I am thirsty!");
                Console.WriteLine(hunter.Name+" - Walking to river");
            }
        }

        public override void Execute(Hunter hunter)
        {
            Console.WriteLine(hunter.Name + " - Drinking some of this fine river water");
            hunter.Thirst = 0;
            hunter.changeToPreviousState();
        }

        public override void Exit(Hunter hunter)
        {
            Console.WriteLine(hunter.Name+ " - going back to my doings...");
        }
    }
}
