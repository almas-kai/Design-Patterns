# Object Pool

The pattern lets you omit heavy initialization logic, or continous object creation/destruction process. The pattern achieves this by keeping a certain number of objects alive at all times, in order to reuse them later.

## Implementation Details

You define a class that keeps track of objects. The class can use any collection type inside. The pool needs to be able to determine if an object is used or free right now. For that you could use internal class, with a simple field `isFree`. You define means to ask or return objects.

Optionally the pool class could limit the number of objects that it keeps alive.

Note that kept objects can contain state that is unique for each use. The pool is responsible for resetting that state when the object is freed. Also remember that kept objects can reference other objects this way they can keep alive a lot of objects in memory. I think the user could provide a cleanup callback that resets unneeded state.

## Notes

A few notes:

* GC is fast at reclaiming small objects. Use this pattern when you initialize a lot of objects, or the initialization logic is heavy.
* The pool should guarantee object consistency.
* Consider unmanaged resource release and thread safety.
* What if a user won't release an object? Maybe timeout-based eviction is a possible solution?
* Use framework provided implementations of course: `ObjectPool<T>` or `ArrayPool<T>`.
* The pool should use empty constructor (default one), or some factory in order to initialize objects.
