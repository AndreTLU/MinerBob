using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerBob.States
{
    class StateMachine<T>
    {
        T _owner;
        State<T> _currentState;
        State<T> _previousState;
        State<T> _globalState;

        public StateMachine(T Owner)
        {
            this._owner = Owner;
            _previousState = null;
            _globalState = null;
            _currentState = null;
        }

        public void Update()
        {
            if (_globalState != null) _globalState.Execute(_owner);
            if (_currentState != null) _currentState.Execute(_owner);
        }

        public void changeState(State<T> _newState)
        {
            _previousState = _currentState;
            _currentState.Exit(_owner);
            _currentState = _newState;
            _currentState.Enter(_owner);
        }

        public void changeToPreviousState()
        {
            changeState(_previousState);
        }
        public void SetGlobalState(State<T> s)
        {
            _globalState = s;
        }
        public void SetCurrentState(State<T> s)
        {
            _currentState = s;
        }
        public void SetPreviousState(State<T> s)
        {
            _previousState = s;
        }

        public State<T> GlobalState { get { return _globalState; } }
        public State<T> PreviousState { get { return _previousState; } }
        public State<T> CurrentState { get { return _currentState; } }
    }
}
