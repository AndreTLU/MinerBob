using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinerBob.Entities;

namespace MinerBob.States
{
    abstract class State<T>
    {
        public State(){ }

        abstract public void Enter(T entity);
        abstract public void Execute(T entity);
        abstract public void Exit(T entity);

    }
}
