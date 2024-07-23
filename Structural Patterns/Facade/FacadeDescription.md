# Facade Structural Pattern

It streamlines a complex system through a simplified interface.

## An Example

Suppose you have a lot of classes that interact to achieve some goal. The clients have to spend some time to understand how the system works, what pitfalls the system has, and how to appropriately configure the system. Then they need to set up the initialization process in the right order so that the system works as expected. However, that is error-prone, and a lot of code must be written. This is where this pattern shines.

## How to implement?

You hide the system behind the interface that will connect the complex system and the clients. Basically declare a class that will forward all the calls to the complex system. The class also has to initialize all the necessary dependencies. If the class becomes too big, split it up (the system can have multiple facade classes that work with the different parts of the complex system). It is recommended that all the client manipulation passes through the facade class.

## Pros

1) Abstracts the complexity away.
2) A single point of access. If the system is switched or replaced with another one, you change it in one place.

## Cons

1) The facade class can get big, in that case split it up.
2) The client code might not have the complete control over the complex system. However, clients can still interact directly with the complex system, but it is not simple and makes the code more complex. (Why direct interaction? Use Facade!).
3) You might need to tweak some things if the complex system changes.
