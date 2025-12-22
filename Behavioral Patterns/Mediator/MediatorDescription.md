# Mediator Behavioral Pattern

Declares a class (**Mediator**) that manages other components. The components cannot communicate with each other, but with the **Mediator** class.

This of an analogy: planes don't talk to each other, each plane talks to a dispatcher instead. And the dispatcher has to make sure that planes don't crash into each other.

## Implementation Details

1. Define an interface for the **Mediator** class. This is important because components will be able to work with different **Mediator** classes in other projects, for example.
2. The interface must define a protocol that will be used by components to communicate their intent.
3. Components must hold a reference to the **Mediator** class as the interface defined in the first step.
4. Components must not be able to communicate directly with each other. Instead, they must communicate with the **Mediator** class.
5. Define a concrete **Mediator** with the necessary methods and fields.
6. Components use the **Mediator**'s protocol. They call a specific method in the **Mediator**, which in turn communicates with other components if necessary.
7. Optionally the **Mediator** class can hold a number of different component instances, and manage their lifetimes.

## Pros

1. OCP is respected. You can add new components or new **Mediator**s without any problems.
2. SRP is respected. You create a specific class that has a single job, to provide a communication link between components. This way your components don't need to implement the logic of communication between themselves.
3. Components can be reused easily.

## Cons

1. The **Mediator** class can get messy, thus degrading the maintainability.
