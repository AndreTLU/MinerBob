using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinerBob.States;

namespace MinerBob.Entities
{
    class Hunter: Entity
    {
        State _currentState;
        State _previousState;

        int _foodCarried;
        int _foodStored;
        int _thirst;
        int _fatigue;

        public Hunter()
        {
            _foodCarried = 0;
            _foodStored = 0;
            _thirst = 0;
            _fatigue = 0;
        }

        public override void Update()
        {
            _thirst += 1;
            _currentState.Execute(this);
        }

        public void addFood(int amount)
        {
            _foodCarried += amount;
        }
        public bool PocketsFull()
        {
            if (_foodCarried >= 25) return true;
            else return false;
        }
        public void storeFood()
        {
            _foodStored = _foodCarried;
            _foodCarried = 0;
        }
        public void rest()
        {
            _thirst -=1;
            _fatigue -= 1;
        }
        public void increaseFatigue()
        {
            _fatigue += 1;
        }

        public void changeState(State _newState)
        {
            _currentState.Exit(this);
            _previousState = _currentState;
            _currentState = _newState;
            _currentState.Enter(this);
        }
    }
}
