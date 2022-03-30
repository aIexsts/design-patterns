``````
Proxy (Surrogate):

Surrogate - a substitute, especially a person deputizing for another in a specific role or office.

lazy loading, caching

Provide a surrogate or placeholder for another object to control access to it.

Types:
Remote - hide the fact that object resides in different address space
Local execution of a remote service (remote proxy). This is when the service object is located on a remote server.

Virtual - perform optimisation on creating object on demand
Lazy initialization (virtual proxy). This is when you have a heavyweight service object that wastes system resources by being always up, even though you only need it from time to time.

Protection, smart reference - allow additional house keeping tasks to be performed on access
Access control (protection proxy). This is when you want only specific clients to be able to use the service object; for instance, when your objects are crucial parts of an operating system and clients are various launched applications (including malicious ones).

Logging requests (logging proxy). This is when you want to keep a history of requests to the service object.

Caching request results (caching proxy). This is when you need to cache results of client requests and manage the life cycle of this cache, especially if results are quite large.

Smart reference. This is when you need to be able to dismiss a heavyweight object once there are no clients that use it.

Participants:

Proxy (ImageProxy)

Subject (Graphic, Common Interface)
RealSubject (Image)
``````

``````
Use Cases:

ImageProxy



``````
