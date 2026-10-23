# Simple Factory Pattern

Simple factory pattern is the member of the factory design patterns family. This pattern abstracts and hides the instantiation logic from the client code.

## Implementation Details

1. Define a base class (or interface) for the various types of products.
2. Define a factory class (often `static`) with a method that returns the appropriate product based on the input parameters. The method returns the base class (or interface) defined in step one.
3. Define the logic of the interface method. This method must determine and return the correct product type based on the provided input.
4. The client code uses the factory class instead of instantiating an instance directly.

## Pros

1. SRP is respected. The factory class is responsible for object instantiation.
2. The creation process is abstracted away.

## Cons

1. OCP is violated. When you add a new product, you need to change the factory class.
2. Scalibility can be a problem if your factory is responsible for a lot of products' creation.
