``````
Adapter (Wrapper): 

Decouple an abstraction from its implementation so that the two can vary independently

Participants:
Abstraction - defines the abstraction interface, maintains reference to an object of type Implementor
RefinedAbstraction - extends interface defined by Abstraction

Implementor - defines interface for implementation classes
ConcreteImplementor - implements the Impletementor interface and defines its concrete implementation

Implementations - Similar to Strategy pattern

Can be combined with Abstract Factory (Singleton)
``````

````
Possible Examples:

AdvancedChartProducer

Pages -> Absraction
SimpleChartBuilder -> Implementation or Strategy/Builders

ReportBuilder.build {

StatisticsPage(SimpleChartBuilder)

BudgetPage(AdvancedChartBuilder)

MoneySection( SimplifiedBarChartBuilder chartBuilder)

}

IStatisticsAlgorithm -> variations of algorithm

can be passed to client 


Remote - Abstraction (Simple Remote, Advance Remote)

Device - interface (Radio, TV)

````


