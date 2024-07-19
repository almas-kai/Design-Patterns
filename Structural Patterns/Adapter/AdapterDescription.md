# Adapter Structural Pattern

This pattern lets you work with incompatible, but similar interfaces. Basically it lets you "adapt" an incompatible interface, so that it looks like you are using your business logic's interface.

## How it works?

Suppose your business logic works with one type of interface. And all of a sudden you need to use a service (third-party or whatever) that uses another (incompatible, but similar) interface. You create an adapter class that implements your business interface, and accepts as a parameter (for a constructor) an incompatible interface. In order to work with the service your business logic calls the adapter class through the interface,  the adapter class performs some additional logic in order to utilize the incompatible interface. So, it looks like you are working with the "normal" interface.

## Two Types of Adapters

There are object and class adapter types. In the first you use composition, and in the second you use multiple inheritance.
