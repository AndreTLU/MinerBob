using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinerBob.Entities;

namespace MinerBob.States
{
    class WifeGlobalState : State<HunterWife>
    {
        private static WifeGlobalState instance;

        private WifeGlobalState() {
            
            EnterHomeAndRest.Instance.HunterHomeHandle += onHunterHomeEvent;
        }
        public static WifeGlobalState Instance
        {
            get
            {
                if (instance == null) instance = new WifeGlobalState();
                return instance;
            }
        }

        public override void Enter(HunterWife entity)
        {
            
        }

        public override void Execute(HunterWife entity)
        {
            
        }

        public override void Exit(HunterWife entity)
        {
            
        }

        public void onHunterHomeEvent(Object sender, EventArgs e)
        {
            //HunterWife hunterWife = (HunterWife)me;
            Console.WriteLine(" - Hi sweety!");
        }
    }
}
