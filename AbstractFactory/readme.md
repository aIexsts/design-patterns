``````
Abstract Factory: 

Emphasizes a family of product objects (either simple or complex)
Focus on *what* is made
Focus on defining many different types of *factories* to build many *products*, and it is not a one builder for just one product
Defers the choice of what concrete type of object to make until run time
*Every* method call creates and returns different objects


Participants:

AbstractFactory
ConcreteFactory
----------------
AbstractProduct
ConcreteProduct
----------------
Client
``````

``````
Use Cases:

Widget Kits, Dialog Kits - portability across different OS

``````
