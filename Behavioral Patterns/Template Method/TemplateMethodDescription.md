# Template Method Behavioral Pattern

Lets you customize some steps of the algorithm.

## Implementation Details

1. Define an abstract class that holds the steps (methods) of your algorithm. These methods can be abstract, so that subclasses can customize them.
2. In the abstract class define a template method. This methods calls steps in the particular order so the template method, essentially defines the ordering of all the steps. The template method shouldn't be abstract.
3. Add hooks if necessary. Hooks let you customize the template method's execution process.
4. Create concrete implementers, and redefine some steps.

## Pros

1. Less duplicate code. You define general steps in the base class, and only customize some parts of an algorithm.
2. The pattern's primary purpose is to give you the ability to customize the algorithm's steps. This gives you flexibility.

## Cons

1. LSP may be violated:
   * Behavioral Changes: If a subclass overrides a method (step) in a way that changes the expected behavior of the template method, it might violate LSP. For example, if the superclass template method expects certain preconditions or postconditions from the steps, and the subclass alters these, it might lead to unexpected results.
   * Inconsistencies: If a subclass doesn't fully respect the contract of the base class, the polymorphic behavior might break. For instance, if a subclass skips a critical step or performs it in a non-compatible way, the entire algorithm's behavior could be altered.
2. If your algorithm has a lot of steps, the pattern might be harder to maintain.

## Use Cases

1. Use it when the subclasses must be able to change the steps of the algorithm.
