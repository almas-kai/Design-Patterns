# Specification Design Pattern

Basically hides some boolean expressions or logic inside of a class. Or more formally, encapsulates some business rules into objects.

## Implementation Details

1. Define a generic contract for a unary specification.
2. Implement the contract for simple cases.
3. You can also define composite specifications.
4. You need an **Evaluator** to apply specifications. It is basically a class that has some members that accept the specifications, and use them.

In .NET use `Expression` if you work with EF Core, since this way you are sending the DB to handle your "specifications".

A great specification is used for 2 different purposes at once:

1. Selection (or filtering).
2. Validation.

You can use parameters to customize the specifications.

## Pros & Cons

Pros:

* You can reuse some code, instead of repeating your filters, for example: pass around a specification inside a filter method. It can be a big specification.
* Can be very handy with the repository design pattern. You just have one `Find` method that accepts a specification, instead of defining tons of helper methods.

Cons:

* Can be overkill for simple projects.
