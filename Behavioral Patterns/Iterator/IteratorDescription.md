# Iterator Behavioral Pattern

Allows you to iterate through different types of collections in a unified way.

## Implementation Details

1. Define an iterator interface for different types of iterators.
2. Define concrete iterator classes that accept a corresponding collection type, and iterate it.
3. Define an aggregator interface.
4. Implement concrete aggregators. Each aggregator returns corresponding iterator instance.

You can also create a method that returns an iterator instance in the collection class itself, instead of using aggregators.

Note that in C#, this pattern is so widely used that you don't need to implement it yourself. The idea behind the `IEnumerable` and `IEnumerator` interfaces is the same idea behind this pattern.

## Pros

1. OCP is respected. You can easily add new collections and iterators.
2. Code complexity is reduced because you are using a unified way to access a collection's items.

## Cons

1. Performance can be a problem.
2. It can introduce unnecessary complexity for simple collection types.
