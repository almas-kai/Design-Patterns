# Visitor Behavioral Pattern

Let's you introduce new operations on related class hierarchy without modifying their classes.

## Implementation Details

1. Define a **Visitor** interface, and a set of methods inside it. Each method in the interface corresponds to one of the class types.
2. Define a concrete **Visitor Implementor** which will define an operation that must be performed by all (or most) of the classes.
3. In the class hierarchy's abstract base class, define an abstract method that will accept the **Visitor** interface.
4. Each derived class must implement the abstract method that was defined in the previous step. This implemented method will call the corresponding method from the **Visitor** interface, passing itself as the argument.
5. The client code must choose the interested **Visitor** implementor and will pass it to the classes.

## Pros

1. OCP is respected. You can add new operations by implementing new **Visitor** classes.
2. SRP is also respected. You separate the implementation of operations from the object structure.

## Cons

1. The **Visitor** cannot see hidden members.
2. If you introduce a new class, you need to update all **Visitors**.

## Usage Cases

1. When you need to add a lot of new operations to a hierarchy.
2. When you need to extract some operations, so that your hierarchy gets cleaner.
