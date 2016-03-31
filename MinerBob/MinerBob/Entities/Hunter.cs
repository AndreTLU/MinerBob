using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinerBob.Locations;
using MinerBob.States;

namespace MinerBob.Entities
{
    class Hunter: Entity
    {
        State _currentState;
        State _previousState;

        int _foodCarried;
        int _foodCounter;
        int _foodWarehouse;
        int _thirst;
        int _fatigue;

        Location.location_type _location;

        public Location.location_type Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public int FoodWarehouse
        {
            get { return _foodWarehouse; }
        }

        bool _enoughFoodForDay = false;

        public Hunter()
        {
            _foodCarried = 0;
            _foodCounter = 0;
            _foodWarehouse = 0;
            _thirst = 0;
            _fatigue = 0;
            _currentState = EnterHomeAndRest.Instance;
            _location = Locations.Location.location_type.HOME;

        }

        public override void Update()
        {
            _thirst += 1;
            _currentState.Execute(this);
        }

        public void IncreaseFatigue(int _amount)
        {
            _fatigue += _amount;
        }
        public bool NeedRest()
        {
            if (_fatigue >= 7) return true;
            else return false;
        }

        public void addFood(int amount)
        {
            _foodCounter += amount;
            _foodCarried += amount;
        }
        public bool PocketsFull()
        {
            if (_foodCarried == 3) return true;
            else return false;
        }
        public void storeFood()
        {
            _foodWarehouse += _foodCarried;
            _foodCarried = 0;
        }
        public void rest()
        {
            _thirst =0;
            _fatigue =0;
            _foodCounter = 0;
        }

        public bool enoughFood()
        {
            if (_foodCounter == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void changeState(State _newState)
        {
            _previousState = _currentState;
            _currentState.Exit(this);
            _currentState = _newState;
            _currentState.Enter(this);
        }

        public void changeToPreviousState()
        {
            State _nextState = _previousState;
            _currentState.Exit(this);
            _nextState.Enter(this);
            _currentState = _nextState;
        }

        public string Stats()
        {
            return "Fat: " + _fatigue + " FoodH: " + _foodCarried + " Count" + _foodCounter;
        }

        
    }
}
