# Builder Pattern

The goal of this pattern is to separate the construction of an object from its representation.

The pattern is useful in these cases (it is assumed that the construction process is complex):

1. When you have a type that has a lot of constructors (overloading) that instantiate objects with different configurations.
2. When you want to reuse the creation process to produce different types of products.

## Players

* Products - different types that you want to produce. They don't have to have the commonality between them, other than the construction process of course.
* Builders - a hierarchy of different builders. A base class (interface) must define a contract for steps to be implemented by concrete builders. Concrete builders must have a method to return the product they constructed. The products can be completely unrelated, thus the base builder class cannot define the return result method.
* Directors - each director defines a strict construction order, meaning construction steps are statically specified. The director is optional (a client can act as one). A director accepts a builder. And upon this builder it acts.
* Client - initializes a concrete builder, passes it to a director (if you have one), and gets the product from the builder.

## C\#

Nuances:

* In C# enable fluent chaining via returning `this` in builders.
* Use records for immutability.
