``````
Command (Action, Transaction): 

Encapsulate a request as an object, thereby letting you paraterize clients with different
requests, queue or log requests, and support undoable operations.

Use the Command pattern when you want to parametrize objects with operations.
Use the Command pattern when you want to queue operations, schedule their execution, or execute them remotely.
Use the Command pattern when you want to implement reversible operations.

Participants:

Command 
ConcreteCommand (PasteCommand, OpenFileCommand)
---------------
Invoker (MenuItem)
Receiver (Document, Application)
---------------
Client (Application)

``````

``````
Use Cases:

Editor with undo operations
MacroCommand (multiple inside)
Open Closed Principle

``````
