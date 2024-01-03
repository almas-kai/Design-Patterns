# Builder Pattern

The goal of this pattern is to separate the construction of an object from its representation. This pattern eases the construction process of different configurations of a complex object.

The construction process doesn't care how each part is assembled.

This complex object is our **product**. We must define a **general interface** that all **concrete builders** have in common. Then we can use the **director** that defines steps to execute (implementation is defined by concrete builders) to get the product. So, we can use the **director** to save, and reuse specific configurations.

As an example consider a computer, it has different parts: HDD or maybe SSD, HD screen or FullHD screen, CPU that has 4 cores or 8 cores, and so on. So, you can construct this product using different configurations.

## Usage Case

Use this pattern when you need to implement different versions of a product.

If your class has a lot of constructors that initialize an object with different configurations, consider using this pattern. But, at the same time if your class is simple you shouldn't complicate your code implementing this pattern.
