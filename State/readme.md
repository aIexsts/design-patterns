``````
State: 

Similar to strategy but each state have a reference to Context and can move itself to different state

The pattern suggests that you extract all state-specific code into a set of distinct classes. As a result, you can add new states or change existing ones independently of each other, reducing the maintenance cost.

Use the State pattern when you have an object that behaves differently depending on its current state, the number of states is enormous, and the state-specific code changes frequently.
Use the pattern when you have a class polluted with massive conditionals that alter how the class behaves according to the current values of the class’s fields.
Use State when you have a lot of duplicate code across similar states and transitions of a condition-based state machine.

Participants:

Context
State 
ConcreteState (Context)



