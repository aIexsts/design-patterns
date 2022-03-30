``````
Builder: 

Focuses on constructing a complex object step by step
Focus on *how* it is made
Focus on building a one complex but one single *product*
Hide the logic/ operation of how to compile that complex 
Only the *last* method call returns the object, while other calls partially build the object

Participants:

Builder
ConcreteBuilder
Product (Complex Object)
----------------
Director (constructs object using Builder)
----------------
Client (uses Director)
``````

``````
Use Cases:

Complex object achieved in steps:

BoxBuilder

Converters of Data to in steps into complex Objects[]
data to Chart1, Chart2, Chart3

HtmlChartBuilder
XmlChartBuilder

Builder used commonly with Composite

Fluent Builder::

Builder can be replaced with class itself using chaining:
Pizza pizza = PizzaBuilder
                   .cheese(true)
                   .pepperoni(true)
                   .bacon(true)
                   .get();
                   
FunctionalBuilder::

var person = new PersonBuilder()
            .Called("Lucas")
            .WorkAs("Developer")
            .Build();


``````
