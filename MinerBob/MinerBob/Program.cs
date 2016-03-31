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
            Hunter hunter = new Hunter("John");
            Hunter hunter2 = new Hunter("Edward");
            hunter2.changeState(EnterForestAndHuntFood.Instance);
            Hunter hunter3 = new Hunter("Carl");
            hunter3.changeState(StoreTheFood.Instance);

            for (int i =0; i<25; ++i)
            {
                hunter.Update();
                hunter2.Update();
                hunter3.Update();

                Thread.Sleep(1000);
            }
        }
    }
}
