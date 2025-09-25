# Prototype Pattern

The Prototype pattern allows you to create an instance of a class by cloning another instance of the same class.

## Usage Cases

1. When you want to avoid resource-intensive operations during the initialization of a new object. Instead, you copy the results without performing heavy computational operations.
2. When you want to avoid creating too many subclasses to configure objects differently. Instead, you copy and make modifications as needed.
3. When you need to create objects dynamically without knowing their exact classes at runtime. You use a general interface and clone objects without specifying their classes.

## Implementation Details

There are two main methods to implement this pattern:

1. By using a constructor that accepts the object and clones its properties.
2. By using the cloning method.

Think carefully whether to use shallow or deep copying. For deep copying you could use serialization, for example, to JSON then back.

C# has `ICloneable` but it doesn't specify whether the cloning must be deep or not. For that reason define your own interface.

MemberwiseClone might be enough sometimes:

>The [MemberwiseClone](https://learn.microsoft.com/en-us/dotnet/api/system.object.memberwiseclone?view=net-9.0) method creates a shallow copy by creating a new object, and then copying the nonstatic fields of the current object to the new object. If a field is a value type, a bit-by-bit copy of the field is performed. If a field is a reference type, the reference is copied but the referred object is not; therefore, the original object and its clone refer to the same object.
