# Command Behavioral Pattern

This pattern lets you encapsulate a request into an object. Thus, manipulating requests becomes easier (e.g. passing it as arguments, queuing and so on).

>Four terms always associated with the command pattern are command, receiver, invoker and client. A command object knows about receiver and invokes a method of the receiver. Values for parameters of the receiver method are stored in the command. The receiver object to execute these methods is also stored in the command object by aggregation. The receiver then does the work when the execute() method in command is called. An invoker object knows how to execute a command, and optionally does bookkeeping about the command execution. The invoker does not know anything about a concrete command, it knows only about the command interface. Invoker object(s), command objects and receiver objects are held by a client object. The client decides which receiver objects it assigns to the command objects, and which commands it assigns to the invoker. The client decides which commands to execute at which points. To execute a command, it passes the command object to the invoker object. -Wikipedia

## Implementation Details

1. Define an interface or base abstract class for the command subclasses. And declare a single method called 'execute' (optional methods like `Undo` can be included if needed). You can also declare additional fields so that the command can encapsulate request's additional data.
2. Implement concrete commands.
3. Define a receiver class. This class executes the business logic. It's called "receiver" because it receives a specific command and runs corresponding logic.
4. Define the invoker class. This class must hold the command(s) that can be executed depending on the situation.
5. The client code must create and configure the command objects, the senders (invokers), and the receivers.
6. Optionally, the commands can be associated with the receivers.

## Pros

1. SRP is respected. The callers are separate from the performers.
2. OCP is respected. You can add new commands without any problems because of the Polymorphism.
3. The undo and redo operations can be implemented relatively easier. The Command Pattern allows you to maintain a history of executed commands, which is useful for implementing undo/redo functionality.
4. The requests can be implemented manipulated easily.
5. The complex commands can be composed from a simpler commands.
6. The commands can be queued or scheduled to execute at a later time or in a specific sequence.

## Cons

1. Maintenance and the overall code structure get harder to understand.
