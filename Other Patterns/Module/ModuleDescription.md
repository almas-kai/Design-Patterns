# Module Pattern

> Closure is when a function can remember and access its lexical scope even when it’s invoked outside its lexical scope.

The most common way to implement this pattern is to use what's called as the `revealing module`.

## Implementation of the revealing module

1. Define a function.
2. Store inner variables.
3. Define inner functions that operate on inner data.
4. Return an object with the functions defined in step 3.

## Notes

The module is just a function that needs to be invoked to create a module instance. Obviously you are using closures here! Note that you need to hide state. The object that is returned is just a public API for our module (you can return a function directly as well).

There must be an outer enclosing function, and it must be invoked at least once. And the enclosing function needs to return at least one inner function, and that function can access/modify the private state. Otherwise it is not a module.

You can pass parameters as well, to your modules.
