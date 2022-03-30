``````
Memento (Snapshots, Token): 

Without violating encapsulation, capture and externalize an object internal state
so that the object can be restored to that state later

Memento is a behavioral design pattern that lets you save and restore the previous state of an object without revealing the details of its implementation.

Use the Memento pattern when you want to produce snapshots of the object’s state to be able to restore a previous state of the object.
Use the pattern when direct access to the object’s fields/getters/setters violates its encapsulation.
 
Participants:

Memento(SolverState)
Originator(Constraint Solver)
Caretaker (Undo mechanism)


``````

``````
Example:

Editor state saving using snapshot to use for undo

``````

