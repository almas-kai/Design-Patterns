# Proxy Structural Pattern

Use it when you want to provide a placeholder or surrogate for another object to control access to it. Basically, you are creating another class that serves as an interface to another type of object. Or you could think of it as wrappers for objects. You work with the interface, not with the original object, but the interface utilizes original object behind the scenes. But why do we need to create another interface for an existing type? These might be reasons:

* Original object is not available.
* You need to add additional functionality without modifying the original class. For example: logging, or various security mechanisms.
* Because of performance, suppose that the original class is heavy, thus it makes sense to create a limited number of original objects, but you can create a lot of proxies that work with those heavy objects.

## Types of proxies

Typical types of proxies:

* Remote proxy is used when the original object is not accessible to the client, because it sits in a different address space (for example, it is on a different computer). So, the proxy object just serves as a forwarding mechanism.
* Virtual proxy is used when optimization techniques, such as creation of heavy objects on-demand, are needed. For example, you could create heavy "versions" of objects only when you need those "heavy" features, in other cases use light copies. This way you can save memory.
* Protection proxy generally deals with different access rights.
* Logging proxy is used to keep track of history.
* Caching proxy is used to manage large number of requested objects.
* Smart reference is used to keep track of references to objects, so this type of proxy decides when to release, when to instantiate original objects. Basically controls the lifecycle of original objects.

## Cons of using proxies

* The response time can take a while, because you are using additional layer.
* A proxy may alter original results.

## Additional considerations

It is not necessary, but it is a good thing to define an interface, so both a proxy and an original class have the same members, thus the proxy can disguise itself as an original object. You also could use inheritance.
