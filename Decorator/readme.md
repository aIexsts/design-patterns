``````
Decorator (Wrapper): 

Static Inheritance

Attach additional responsibilities to an object dynamically. 
Decorators provide a flexible alternative to subclassing for extending functionality.

Participants:

Component
ConcreteComponent

Decorator
ConcreteDecorator
``````

``````
Example:

FaceBook Notifier
Slack Notifier
SMS Notifier

Merge Notifiers by Decorator Pattern

[SMS + Facebook + Slack]
[SMS + Slack]

notifier = new Notifier()
if (facebookEnabled){
    notifier = new FacebookDecorator(notifier)
} 
if (slackEnabled){
    notifier = new SlackDecorator(notifier)
}

app.setNotifier(notifier)

...

In C# use DELEGATES!

PhotoProcessor.PhotoFilterHandler filterHandler =    
 filters.ApplyBrightness;

 filterHandler += filters.ApplyContrast;
 filterHandler += filters.Resize;
 filterHandler += RemoveRedEyeFilter;


``````

