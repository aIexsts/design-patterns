``````
Chain of Responsibility: 

Use the Chain of Responsibility pattern when your program is expected to process different kinds of requests in various ways, but the exact types of requests and their sequences are unknown beforehand.

Use the pattern when it’s essential to execute several handlers in a particular order.
 
Use the CoR pattern when the set of handlers and their order are supposed to change at runtime.


Participants:

Handler
ConcreteHandler

Client
``````

``````
Use Cases:

Often applied in conjunction with Composite

``````
