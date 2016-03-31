using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinerBob.Entities;

namespace MinerBob.States
{
    abstract class State
    {
        public State(){ }

        abstract public void Enter(Hunter hunter);
        abstract public void Execute(Hunter hunter);
        abstract public void Exit(Hunter hunter);

    }
}
