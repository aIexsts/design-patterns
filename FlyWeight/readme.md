``````
FlyWeight:

Caching/reusing objects 

Use sharing to support large numbers of fine-grained objects efficiently

The Flyweight stores a common portion of the state (also called intrinsic state) that belongs to multiple real business entities. The Flyweight
accepts the rest of the state (extrinsic state, unique for each entity) via its method parameters.

Participants:

Flyweight (Glyph)
ConcreteFlyweight (Character)
UnsharedConcreteFlyweight (Row, Column)
----------------
FlyWeightFactory
Client
``````

``````
Use Cases:

Document Editor

``````
