# Repository Pattern

It is a pattern that separates data access layer from the domain layer. In short, it abstracts data persistence.

## Implementation Details

Think of this pattern as a defining and following a contract for some kind of collection data type.

1. Define a contract in the **Domain** layer, so that it dictates how your entities can be used.
2. Implement this contract in the infrastructure layer with whatever implementation details you want to.
3. Clients don't care about implementations, they just care about the contract itself.

## Pros & Cons

Pros:

* SRP is respected, clients don't need to worry about implementation details.
* OCP is respected you can introduce a lot of different repositories if you want to.
* Testing becomes easier, you just mock or fake your repository.

Cons:

* Can be overkill for small projects, as you have to maintain hierarchies.
