``````
Observer:

Define a one to many dependency between objects so that when one objects 
changes state, all its dependents are notified and updated automatically.

Use the Observer pattern when changes to the state of one object may require changing other objects, and the actual set of objects is unknown beforehand or changes dynamically.
Use the pattern when some objects in your app must observe others, but only for a limited time or in specific cases.

Participants:

Subject 
Observer

ConcreteSubject
ConcreteObserver

``````

``````
Use Cases:

Update multiple dashboard sections when data modified
Weather dashboard for multiple cities

Observer can we wathching for multiple subjects


``````
