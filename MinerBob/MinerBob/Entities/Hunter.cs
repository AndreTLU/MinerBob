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
        int _foodCarried;
        int _foodCounter;
        int _foodWarehouse;
        int _thirst;
        int _fatigue;
        string _name;

        StateMachine<Hunter> _StateMachine;

        List<BaseItem> inventory = new List<BaseItem>();

        Location.location_type _location;

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

        public Hunter(string _text)
        {
            _foodCarried = 0;
            _foodWarehouse = 0;
            _thirst = 0;
            _fatigue = 0;
            Name = _text;
            _StateMachine = new StateMachine<Hunter>(this);
            _location = Locations.Location.location_type.HOME;

        }

        public override void Update()
        {
            _thirst += 1;
            _StateMachine.Update();
        }

        public void IncreaseFatigue(int _amount)
        {
            _fatigue += _amount;
        }

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

        public List<BaseItem> Inventory
        {
            get { return inventory; }
        }

        public void AddItem(BaseItem item)
        {
            inventory.Add(item);
        }

        public void UseItem(BaseItem item)
        {
            Consumable itemUsed = (Consumable)item;
            itemUsed.Charges--;
            Thirst -= itemUsed.Restore;
        }

        public StateMachine<Hunter> GetSM()
        {
            return _StateMachine;
        }
    }
}
