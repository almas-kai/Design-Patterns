# Result pattern

Exceptions are for exceptional situations! Use the **Result** pattern to indicate if something has failed or not.

## Implementation Details

1. Define a generic **Result** class that represents if the operation has failed or not.
2. Define `IsSuccess`, `Error` and `Value` field as a bare minimum.
3. `Error` will be `null` if `IsSuccess` is `true`, `Value` will be whatever you expect it to be, in this case.
4. Now operations return `Result`. You inspect the contents of it, and react accordingly.

You still can throw errors, but only if an exceptional situation happens.

You can define helper class, that runs some logic depending on the `IsSuccess`.

## Pros and Cons

Pros:

1. You don't need to worry if an operation can throw some exception.
2. Unified way to handle operation's results.
