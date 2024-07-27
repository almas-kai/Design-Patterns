# Flyweight Structural Pattern

Reuses the data that is same for the majority of objects, thus saves some memory.

## Implementation Description

1. Create a so-called flyweight class;
2. Extract the state that is same to every instance (or most of the instances);
3. Put that state into the flyweight class;
4. Limit the amount of the flyweight instances that your app can create (although this is optional, it is recommended to use factory method pattern for this);

So, basically you cache some amount of flyweight instances (which are context-independent) that will be shared among other context-dependent unique instances.

## Some Details

The state that is shared through the flyweight class is called intrinsic, and the state that is unique to each instance is called extrinsic.

You also can pass extrinsic state to the flyweight class at runtime.

Some flyweight instances can be unshareable, meaning they can ignore the extrinsic state that is passed to them.

Basically, whenever you need an object you pass your extrinsic state to the flyweight object, thus configuring it on the fly.

## Pros

Potentially can save some memory.

## Cons

The code becomes complicated.
