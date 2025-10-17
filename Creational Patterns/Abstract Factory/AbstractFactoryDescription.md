# Abstract Factory

It is a creational design pattern that focuses on delivering families of products while obscuring their concrete implementations.

## Key Players

1. Products - the products you want to initialize after all. Since this pattern focuses on families of products, each kind of product has a base class (or interface). Products may or may not interact with each other, but when they do, the Abstract Factory ensures that those interactions happen between compatible products from the same family.
2. Factories - each factory delivers one family of product. Abstract factory defines methods that need to be implemented. Each method return a type of product. Each concrete factory implements the abstract factory interface and is responsible for creating a consistent family of products.
3. Clients - work with abstract factories & abstract products, thus utilizing polymorphism. Sometimes simple factory is combined with this pattern to deliver the concrete implementation of the abstract factory. In this situation clients don't need to initilize factories directly.

## Pros & Cons

This pattern lets you switch factories at runtime. But at the same time, it is hard to use this pattern overall. If you need a new product kind you have to change the hierarchy of factories, and implement the product's hierarchy.

The pattern enables you to logically unite families of products under a concrete factory. Which is convenient.
