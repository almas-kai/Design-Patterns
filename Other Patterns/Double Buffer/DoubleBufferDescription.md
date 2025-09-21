# Double Buffer Pattern (or optimization technique)

The pattern is very useful when you have a producing thread, and consuming thread that are working on the same collection. Because of that you might get these problems:

* Corrupted state.
* Partial updates.
* Flickiring (in GPU intensive operations).

To solve them you define 2 buffers. One of them will be front buffer which is used by consumer, and the other is back buffer which is hidden from the consumer, and used by the producer. When the producer finishes its work of updating data, it performs swap operation, to swap the front and back buffer roles. Now the back buffer becomes the front, the consumer consumes this buffer. And previous front buffer becomes the back buffer, ready to be reused.

This buffer takes up some memory, but gives stability.

Now if the consumer is faster, this pattern works great. If the producer is faster, the consumer may skip some data.
