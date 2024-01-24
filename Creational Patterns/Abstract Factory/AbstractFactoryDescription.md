# Abstract Factory

Also known as the factory of factories. Basically you have the main factory class that groups other concrete factories under a higher level concept or theme (abstraction for factories), each factory gives you a family of objects (different instances of different classes, that are related somehow), those objects can work with each other inside that family, but don't interact with other families. Usually you return not concrete classes, but abstract ones, this way you implement loose coupling.

Your main factory must work with abstractions, so you are performing loose coupling. This is the main point. Because of this you can introduce new factories with ease, and you are also maintaining SRP, and Open/Closed principle.

## Example

Suppose you have a graphical UI. This UI's appearence depends on the OS under which it works. But your code works with abstractions, it doesn't care about the underlying details. In this case products are elements, like buttons, checkboxes, and so on. They must implement their abstract base type, which your program uses. However, a special factory will return concrete implementations, your program works with abstractions. This way you are getting loose coupling thing.

## How to use

1. Define abstract interface for each product type.
2. Define generic interface for abstract factory.
3. Define concrete products.
4. Define concrete factories that combine families of products.
5. Group factories under main factory.
6. Work with abstractions: return abstract factory types, that in their turn return abstract product types.

## When to use

* When your system needs to support multiple families of related products, and the products within a family must work together seamlessly.
* When you want to write platform-independent code that can work with different families of products without being tied to their concrete implementations.
* When there's a possibility of extending the set of product families in the future without modifying existing client code. This adheres to the Open/Closed Principle.
* In scenarios where system configurations or settings determine the types of objects to be created, and you want to encapsulate these configurations in factories.

## Pros & Cons

Pros:

* The pattern promotes flexibility by allowing the addition of new families of products without modifying existing code.
* It decouples client code from concrete product implementations, making it easier to replace or extend product families without affecting the client.
* Ensures that products within the same family have consistent interfaces, making them interchangeable without impacting client code.
* Supports principles such as the Single Responsibility Principle (SRP), Open/Closed Principle.

Cons:

* The pattern introduces additional complexity, especially when dealing with a large number of product families and their variations.
* Selecting the appropriate factory at runtime based on some condition may introduce overhead, especially if there are many conditional statements.
