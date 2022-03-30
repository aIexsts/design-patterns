``````
Visitor: 

Visitor is a behavioral design pattern that lets you separate algorithms from the objects on which they operate.
 
Use the Visitor when you need to perform an operation on all elements of a complex object structure (for example, an object tree).
Use the Visitor to clean up the business logic of auxiliary behaviors.
Use the pattern when a behavior makes sense only in some classes of a class hierarchy, but not in others.

You can extract this behavior into a separate visitor class and implement only those visiting methods that accept objects of relevant classes, leaving the rest empty.

Participants:

Visitor
ConcreteVisitor

Element
ConcreteElement

ObjectStructure (Tree, List) -> with Iterator apply Visitor


Use Cases:

You can use Visitor to execute an operation over an entire Composite tree.
You can use Visitor along with Iterator to traverse a complex data structure and execute some operation over its elements, even if they all have different classes.

