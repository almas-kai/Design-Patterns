# Factory Method Pattern

>Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory method lets a class defer instantiation to subclasses

This pattern lets you create different kinds of objects through the abstract base class. Subclasses decide what kind of objects are going to be created.

## Implementation details

When implementing you have to support two types of hierarchies:

1. Hierarchy of products.
2. Hierarchy of factories.

The first one defines the different classes (products) that you want to create objects from, and that have something in common. You extract this "something in common" to the **interface**, and all your products must implement this interface. For example, all vehicles can move, so it makes sense to create an interface called `IVehicle` (`IMove` actually makes more sense, but you can add other logic that different types of vehicles have in common), that has one method in it `Move()`. Other classes (products, e.g. `Car`, `Truck`, and so on) have to implement that interface.

The second one defines one **abstract superclass** that is intended to be the general interface that your clients work with. It must define a method that concrete factories override to create specific objects, and maybe additional members that are used in business logic. This method must return the general interface that all products implement. For example, `AbstractVehicleFactory` defines one method `CreateVehicle`, that other concrete factories override (`CarFactory`, `TruckFactory` and so on). All different `CreateVehicle`s return `IVehicle`.

When you use it you must pass an instance of the concrete factory, so that superclass creates an instance of the product.

## What it gives?

Let's consider what advantages this pattern gives:

1. This pattern is utilizing polymorphism, this way you are avoiding tight coupling.
2. With this pattern you are implementing Open/Closed Principle (OCP), where you can add new products without any problem.
3. It also introduces the encapsulation of object creation logic, client code doesn't need to worry about the instantiation details.
4. Centralized configuration is another beneficial thing this pattern can achieve. In the factory classes you can include some other product specific logic.

However remember that the code is becoming a little complex, you need to take care of two different hierarchies, with their own configurations, and specific business logic.
