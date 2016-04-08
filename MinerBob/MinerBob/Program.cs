using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinerBob.Entities;
using MinerBob.States;
using System.Threading;

namespace MinerBob
{
    class Program
    {
        static void Main(string[] args)
        {
            EntityManager entityManager = EntityManager.Instance;
            Hunter hunter = new Hunter("John");
            HunterWife hunterWife = new HunterWife("Mia");
            Consumable bottle = new Consumable("Water bottle", "Bottle fileld with water", 5, 3, 1);
            hunter.AddItem(bottle);
            hunter.GetSM().SetCurrentState(EnterHomeAndRest.Instance);
            hunterWife.GetSM().SetGlobalState(WifeGlobalState.Instance);
            entityManager.AddEntity(hunter);
            entityManager.AddEntity(hunterWife);


            for (int i =0; i<45; ++i)
            {

                hunter.Update();
                hunterWife.Update();

                Thread.Sleep(1000);
            }
        }
    }
}
