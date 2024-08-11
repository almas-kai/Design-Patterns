# The Strategy Behavioral Pattern

In this pattern you define different types of algorithms (strategies, these belong to the same family of algorithm) that can be swapped during a runtime in the client class (context). So you define different types of strategies, and use them in different contexts.

## Implementation Details

1. Define a context class that will delegate the work to the strategies.
2. Define an interface that encapsulates common logic which different strategies share.
3. Define concrete strategies.
4. In the context class define a field for the strategy interface. Also define a method that will set this field, so that a client can supply different strategies depending on a situation.
5. In the context class delegate the work to the strategy instance.
6. Clients need to choose the right strategy and supply it to the context class.

Note that in modern programming, in some cases, you easily can use anonymous methods instead of this pattern.

Also note that this pattern is very suitable if your code contains `if-else` or `switch` statements that choose which algorithm to execute.

## Pros

1. OCP is respected. You can easily define new strategies.
2. Separation of concerns. The algorithm's implementation is separate from the context class.
3. Flexibility at runtime. Clients can easily swap the strategy.

## Cons

1. Clients must be aware of the available strategies to select the appropriate one.
2. Potential overkill for a small project.
