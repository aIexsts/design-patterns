``````
Facade: 

Use the Facade pattern when you need to have a limited but straightforward interface to a complex subsystem.
Use the Facade when you want to structure a subsystem into layers.

Provide a unified interface to a set of interfaces in a subsystem.
Facade defines a higher-level interface that makes the subsytem easier to use.

Participants:

Facade 
SubSystem Classes
``````

``````
Use Cases:

VideoConverter (VideoFile, AudioMixer, CodecFactory, BitrateReader) -> convert()

``````

``````
From Clean Architecture:

Single Responsibility Principle [module responsible for only one actor]

Employee [being used by various actors differently]:
+ calculatePay() - CFO
+ reportHours() - COO
+ save() - CTO

Employee: [split to subsystems]

PayCalculator:
+ calculatePay()

HoursReporter:
+ reportHours()

EmployeeSaver:
+ save()

Have Employee class behave as a Facade:

EmployeeFacade:
+ calculatePay() -> PayCalculator
+ reportHours() -> HoursReporter
+ save() -> EmployeeSaver

OR

Employee behaves itself as a Facade: [business domain closer to data]
+ data
+ caclulatePay -> PayCalculator.calculatePay()
+ reportHours -> HoursReporter.reportHours()
+ save
``````
