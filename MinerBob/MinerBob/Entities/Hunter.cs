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
        string _name;

        Location.location_type _location;

        public State PreviousState
        {
            get { return _previousState; }
        }

        public int Thirst
        {
            get { return _thirst; }
            set { _thirst = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Fatigue
        {
            get { return _fatigue; }
        }

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

        public Hunter(string _text)
        {
            _foodCarried = 0;
            _foodWarehouse = 0;
            _thirst = 0;
            _fatigue = 0;
            Name = _text;
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
        //public bool NeedRest()
        //{
        //    if (_fatigue >= 7) return true;
        //    else return false;
        //}

        public void addFood(int amount)
        {
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
            _foodCounter += _foodCarried;
            _foodCarried = 0;
        }
        public void rest()
        {
            _foodCounter = 0;
            _fatigue = 0;
        }

        public bool enoughFood()
        {
            if (_foodCounter >= 8)
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
            changeState(_previousState);
        }


    }
}
