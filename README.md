# MinerBob

Learning StateMachines in order to improve knowledge of C# and AI programming.

EnterHomeAndRest State
EnterForestAndHuntFood State
  Hunter enter forest and hunts for food.
  When his "inventory" is full he goes to Warehouse(StoreTheFood).
QuenchThirst State
  Hunting makes you thirsty.
  When hunter is thirsty he drinks water from a bottle.
StoreTheFood State
  Having pockets only for 3 food hunter needs to store food somewhere.
  
StateMachine : State 
  Middleware between hunter and his States.
  Updates hunter's '_currentState' everytime 'Update()' method is called.
