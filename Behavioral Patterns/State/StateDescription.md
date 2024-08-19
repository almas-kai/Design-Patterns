# State Behavioral Pattern

Lets an object alter its behavior in response to its state change. It makes an object as though it can change its class at runtime.

## Implementation Details

1. Define a **Context** class. This is the class that will behave differently depending on its state.
2. Define a **State Interface** that will hold members of different state classes.
3. Define a field (or property) in the **Context** class to hold its current state.
4. Implement the **State Interface** to define different types of states that your app requires.
5. Inside the constructor of the **Context** class set the initial state.
6. Define a method that will change the current state of the **Context** class.
7. Concrete state classes must accept the current **Context** class they are operating on. Through this reference you call the method in the **Context** class, and set appropriate state.
8. The **Context** class must delegate the work related to state's logic to the state implementor.

So the state can be changed through the **Context**'s method.

## Pros

1. SRP is respected as each state implementation is responsible for its own logic.
2. OCP is respected since new states can be introduced easily through polymorphism.
3. You can easily implement state-machine logic.
4. You can get rid of ugly `if-else` or `switch` conditionals.

## Cons

1. The overall complexity can grow. By introducing new states your code base and possible states that your **Context** can be in grows a lot. Thus making maintenance hard.
