using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinerBob.Entities;
using System.Threading;

namespace MinerBob
{
    class Program
    {
        static void Main(string[] args)
        {
            Hunter hunter = new Hunter();

            for(int i =0; i<25; ++i)
            {
                hunter.Update();

                Thread.Sleep(1000);
            }
        }
    }
}
