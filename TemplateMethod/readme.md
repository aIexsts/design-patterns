``````
Template Method: 

Define the skeleton of an algorithm in an operation, deferring some steps to subclasses.
Template method lets subclasses redefine certain steps of an algorithm without changing algorithm structure.

Use the Template Method pattern when you want to let clients extend only particular steps of an algorithm, but not the whole algorithm or its structure.
Use the pattern when you have several classes that contain almost identical algorithms with some minor differences. As a result, you might need to modify all classes when the algorithm changes.

Participants:

AbstractClass (Primitive Operations, Hooks)
ConcreteClass

Use Cases:

processData()
    validateAbstractStep()
    step1()
    step2
    step3
    abstractstep()
    step4()

User For Games: GameAI -> OrcsAI, MonstersAI
Override methods like: collectResources(), buildUnits() with takeTurn() method

View, Component -> hooks, lifecycle of something

Can be used as Strategy, 
Factory method is a subtype of Template Method



