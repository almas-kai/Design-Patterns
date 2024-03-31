# Decorator Structural Pattern

In some sense it is an alternative to inheritance. So you can introduce new functionality (responsibilities) without breaking existing code (Open-Closed Principle). Often this pattern is used to add (or remove) new functionality (responsibilities) dynamically.

## Pros & Cons

### Pros

1. Very well suited to follow the SRP, OCP, and separation of concerns.
2. Can be used instead of inheritance.
3. Can be used to dynamically add / remove responsibilities from objects. Which makes it very flexible.

### Cons

1. It can introduce complexity, thus making the codebase hard to understand and maintain.
2. The order in which dependencies are applied can affect the final object's behavior in an unexpected way.
3. Performance overhead is added for each wrapper.
4. Some objects just aren't well suited to be used with decorators. It might be because of complex initialization logic, or specific ordering of wrappers, or anything else. They are just not well suited.

## Additional Notes

The pattern is used to add new functionality without breaking existing one, while doing it all dynamically. This is what makes this pattern so flexible.

The decorator pattern is also called the wrapper pattern, because it uses composition to introduce new functionality.

## Example

Suppose you are creating a realistic video game about armored vehicles, in which you simulate damaging system. Depending on where you get shot at, the damage will be different, and so the outcome. The vehicles also have the ability to repair itself. This is where the wrapper pattern comes in handy. The vehicles can change their models, functionalities, and / or appearance depending on taking or repairing damaged zones. All of this must happen dynamically, so you add or remove decorators.

## Implementation Details

1. Extract common logic of the primary class and its future layers' to the interface.
2. Implement base interface that other wrappers will use. Define a polymorphic field that represents the wrapped object.
3. Create concrete wrappers that follow the common interface defined in the second step.
4. Make sure that client code is responsible for creating decorators and composing them in the way the client needs.
