# Bridge Structural Pattern

Divides the abstraction from the implementation, so that they can vary independently. This pattern is suitable when you need to develop abstraction and implementation independently.

In simpler words, when your class is large, and it's extending in two different directions, you could divide this class into the implementation and abstraction parts. The abstraction part hides the complexity and delegates tasks to the implementation part. So, in this case you essentially you maintain two different hierarchies: abstraction hierarchy: you have different refined abstractions (concrete implementers of the abstraction); implementation hierarchy, you have different types of implementations that will be used in refined abstractions.

## Implementation Steps

1) Your class can't be extended in two different directions as that can get messy. So, identify these two different directions and split them. One part will become abstraction and the second one will become implementation. Abstraction uses implementation.
2) Determine the general logic that clients use when working with the abstraction class.
3) Identify the general logic the different types of implementations will have, and define an interface for the implementations.
4) Your abstraction class must have a 'has-a' relationship with the implementation interface.
5) The abstraction delegates most of its work to an implementation.
6) Define different types of refined abstractions if needed.
7) The clients will only pass the implementation type (concrete implementation) to the abstraction and work with the abstraction only.

## Pros

1) OCP is respected. You can introduce new types of refined abstractions or new implementation types independently of each other.
2) Improved maintainability.

## In What Cases To Use?

1) When you have a monolithic class that has more than one reason to be extended.
2) When you need the ability to switch to a different implementation at run-time.
3) When you want to share an implementation among multile objects.
4) When both abstraction and implementation need to be extended.
