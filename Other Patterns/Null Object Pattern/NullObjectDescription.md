# Null Object Pattern

The pattern defines a no-behavior subtype, allowing clients to treat objects from the hierarchy uniformly.

## Implementation Details

1. Define an interface or a base class.
2. Define concrete implementations.
3. Define a special class that does nothing but implements the interface (or base class).
4. Client code can work with the objects in the hierarchy in a uniform way.

## Pros

1. It removes the need for cumbersome null checks.
2. The objects of the hierarchy can be treated in a uniform way.

## Cons

1. Sometimes it can hide potential bugs by not treating null cases specially.
2. Memory can be a concern, but this is usually mitigated by using the **Singleton Creational Pattern**.
