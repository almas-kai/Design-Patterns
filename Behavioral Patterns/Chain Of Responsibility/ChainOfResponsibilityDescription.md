# Chain Of Responsibility Behavioral Pattern

Introduces a set of handlers that process the requests in sequential order. Each handler can decide whether to pass the request to the next handler or to process and terminate the chain.

## Implementation Details

1. Define a base class or interface for the handlers.
2. The base class must include a field to store a reference to the next handler, along with optional methods to configure the handler.
3. Implement concrete handler classes.
4. The client code must define the order in which the requests will be processed.

## Pros

1. SRP is respected because you are creating a class for each handler's logic.
2. OCP is respected because you can introduce new handlers without modifying the existing ones.
3. You can dynamically add/remove the handlers at runtime.
4. You have the full control over the request processing order.

## Cons

1. A request might reach the end of the chain without being handled.
