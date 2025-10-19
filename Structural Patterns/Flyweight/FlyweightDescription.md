# Flyweight Pattern

Lets you save up some memory by reusing objects, configuring them at runtime if necessary.

If you have a class that initializes a lot of objects at runtime, and those objects have some state that is same for every or for a majority of objects, this pattern lets you optimize memory usage. The state that is same for a majority of objects is called **intrinsic state**, and it is included to the flyweight class. Also the state that is unique for each instance could be supplied to the flyweight class at runtime, this state is called **extrinsic state**. Essentially you reuse already defined data instead of polluting the memory with copying the same data and keeping a ref to it.

This pattern often times is combined with the object pool pattern. Essentially you define a class that manages a bunch of flyweight objects, and configures them on request, then returns them to a client.

The dictionary (hash-map) data type is a good tool to implement this pattern.
