# Observer Behavioral Pattern

In this pattern, you define two classes: a publisher and a bunch of subscriber classes. The publisher notifies subscribers when certain events occur.

## Implementation Details

1. Define the `IObserver` interface that at a bare minimum holds one method called Update and that accepts an instance of the publisher class. This way you can pass context data.
2. Implement concrete observers (AKA subscribers).
3. Define a publisher class that will hold `IObserver` collection. Also define a means to register and unregister from notifications.
4. You can use this class in other classes to notify about relevant events or changes..

## Pros

1. OCP - is respected. You can easily add new types of subscribers, they just need to implement the `IObserver` interface.

## Cons

1. Potential memory leakage. You need to implement a mechanism that will remove unneeded objects from the list of subscribers.
