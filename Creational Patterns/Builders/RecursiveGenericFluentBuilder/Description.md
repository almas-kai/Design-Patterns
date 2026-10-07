# Recursive Generic Fluent Builder

Also known as: CRTP-style builder (Curiously Recurring Template Pattern), F-bounded polymorphism builder.

## Goal

Keep a fluent chain fully usable across a hierarchy of builders. No matter which method you call, in what order, every other method in the chain should still be callable next — not just the ones on whatever class you happen to land on.

## The problem it solves

In a normal builder hierarchy, a base-class method returns the base type. Once you call it, you lose access to the derived class's methods — the compiler only sees the declared return type, not the real runtime type. This pattern replaces the fixed return type with a generic one, so the "current type" can travel down the chain.

## The core trick

Every class in the hierarchy is generic over `TSelf`, self-constrained: `where TSelf : ThisClass<TSelf>`. Each method casts `this` to `TSelf` and returns it. `TSelf` is a placeholder for "whatever the final, most-derived builder ends up being" — the class doesn't need to know that type while it's written.

**Important:** that cast is a leap of faith, not a proven fact. The compiler only confirms `TSelf` satisfies the constraint — it never confirms that *this particular instance* actually is `TSelf`. Safety comes entirely from how the chain is closed, not from the type system.

## Players

- **Root builder** — holds the product instance, exposes `Build()`. Non-generic.
- **Intermediate builders** — each contributes one group of fluent methods (a "facet"), parameterized by `TSelf`.
- **Leaf builder** — concrete, non-generic, closes the chain by inheriting the topmost generic builder as `TSelf = itself`.
- **Client** — starts from the leaf's entry point, chains methods in any order.

## Why the product needs its own dedicated "closer" class

Take a `PC` product built from `CPUBuilder<TSelf>` → `RAMBuilder<TSelf>` → `SSDBuilder<TSelf>`. Why not just make `PC` itself inherit `SSDBuilder<PC>` and skip the extra nested `Builder` class entirely?

Two separate reasons, one of them the whole point of the Builder pattern in the first place:

1. **Generics need a concrete terminus.** `TSelf` is a dangling placeholder at every generic level — nothing is actually `TSelf` until something *non-generic* closes the chain by substituting itself. Without that concrete class, you just have an infinite stack of unresolved generic definitions; nothing is ever instantiable.
2. **The finished product must not carry construction methods.** This is the original premise of the Builder pattern: *separate construction from representation*. If `PC` itself were the closing class, every `PC` instance — even fully built, handed off, stored, serialized — would permanently expose `.CPU(...)`, `.RAM(...)`, `.SSD(...)`. That's a half-built object's API leaking into a finished object's public surface. `Build()` exists specifically to hand back a clean product with none of that.

So the closing class has to be **separate from the product** and **deliberately empty** — it contributes zero new methods; its only job is to fix `TSelf` to a concrete type, which is what finally resolves every inherited method's return type down the whole chain. Nesting it inside the product (`PC.Builder`) is pure convention — keeps `PC.New` discoverable and groups the builder with what it builds — not a structural requirement. It could just as well be a standalone top-level class.

```csharp
public class PC
{
    public string? CPU, RAM, SSD;
    public class Builder : SSDBuilder<Builder> { }   // the empty "closer"
    public static Builder New => new();
}
```

## Closing the chain safely

Once an object is only ever instantiated through the leaf, `this` inside every inherited method genuinely is the leaf type at runtime — the cast succeeds. If something else closes a generic level with a mismatched type, the cast still *compiles* and throws `InvalidCastException` at runtime instead. Lock it down: keep the generic intermediate classes out of your public API, and only expose the closed leaf via a static factory.

## Nuance: "wrapped" vs "flat"

Two ways an intermediate builder can pass `TSelf` down to its base class:

- **Wrapped:** `Derived<TSelf> : Base<Derived<TSelf>>`
- **Flat:** `Derived<TSelf> : Base<TSelf>`

At exactly 2 levels, both behave identically — which is why a 2-level example teaches you the wrong lesson. At 3+ levels they diverge, and the difference is a real, compiler-enforced bug, not a style nitpick.

## Worked trace: why the wrapped form breaks at 3+ levels

Consider a three-facet builder:

```csharp
public class CPUBuilder<TSelf>
    : BuilderAbstract
    where TSelf : CPUBuilder<TSelf>
{
    public TSelf CPU(string cpu) { Computer.CPU = cpu; return (TSelf)this; }
}

public class SSDBuilder<TSelf>
    : RAMBuilder<SSDBuilder<TSelf>>
    where TSelf : SSDBuilder<TSelf>
{
    public TSelf SSD(string ssd) { Computer.SSD = ssd; return (TSelf)this; }
}
```

Assume `RAMBuilder` follows the same wrapped convention: `RAMBuilder<TSelf> : CPUBuilder<RAMBuilder<TSelf>>`. Leaf: `PC.Builder : SSDBuilder<Builder>`.

Substitute step by step, starting from `Builder`:

| Step | Expression | Resolves to |
| --- | --- | --- |
| 1 | `Builder`'s base | `SSDBuilder<Builder>` |
| 2 | `.SSD()` on `SSDBuilder<Builder>` | returns `Builder` (own method, fine) |
| 3 | `SSDBuilder<Builder>`'s base | `RAMBuilder<SSDBuilder<Builder>>` — call it `R` |
| 4 | `.RAM()` on `R` | returns `SSDBuilder<Builder>` (own method — still has `SSD()`, fine) |
| 5 | `R`'s base | `CPUBuilder<R>` |
| 6 | `.CPU()` on `CPUBuilder<R>` | returns `R` |

Now check: does `R` (= `RAMBuilder<SSDBuilder<Builder>>`) have `.SSD()`? Its ancestry is `R → CPUBuilder<R> → BuilderAbstract`. `SSDBuilder<TSelf>` is nowhere in there — `R` is `SSDBuilder<Builder>`'s **base**, not its derivative. **`R` does not have `.SSD()`.**

So:

```csharp
PC.New.CPU("i9").SSD("2TB");     // ✗ does not compile — CPU() returns R, which lacks SSD()
PC.New.CPU("i9").RAM("32GB").SSD("2TB"); // ✓ compiles — RAM() climbs back to SSDBuilder<Builder>
```

The chain isn't *fully* order-independent — it's order-independent only if facets are touched in build-order (shallow → deep). That defeats the entire premise of the pattern. Verify this in an actual compiler; the inferred type named in the error is the fastest way to see exactly where the chain narrows.

**Fix — flatten every level:**

```csharp
public class RAMBuilder<TSelf> : CPUBuilder<TSelf> where TSelf : RAMBuilder<TSelf> { ... }
public class SSDBuilder<TSelf> : RAMBuilder<TSelf> where TSelf : SSDBuilder<TSelf> { ... }
```

Now every level's base is instantiated with the same unwrapped `TSelf`, so every method, from every node, always resolves back to the leaf. **Rule: always use the flat form**, even at 2 levels — the wrapped form has no upside and is a trap waiting for a third facet.

## The opposite need: enforcing a strict step order

The `TSelf`-recursive mechanism exists to make facets callable in *any* order. If the actual requirement is the reverse — steps *must* happen in a fixed sequence (`CPU` before `RAM` before `SSD`) — don't bend this pattern to do it. Use a **Step Builder**: a linear sequence of interfaces, one per step, where each interface exposes only the *next* step's method. No `TSelf`, no self-constraint, no generics at all.

```csharp
public interface INeedsCpu { INeedsRam CPU(string cpu); }
public interface INeedsRam { INeedsSsd RAM(string ram); }
public interface INeedsSsd { IBuildable SSD(string ssd); }
public interface IBuildable { PC Build(); }

internal sealed class PCBuilder : INeedsCpu, INeedsRam, INeedsSsd, IBuildable
{
    private readonly PC pc = new();

    INeedsRam INeedsCpu.CPU(string cpu) { pc.CPU = cpu; return this; }
    INeedsSsd INeedsRam.RAM(string ram) { pc.RAM = ram; return this; }
    IBuildable INeedsSsd.SSD(string ssd) { pc.SSD = ssd; return this; }
    PC IBuildable.Build() => pc;

    public static INeedsCpu New => new PCBuilder();
}
```

```csharp
PC pc = PCBuilder.New.CPU("i9").RAM("32GB").SSD("2TB").Build(); // only legal order
PCBuilder.New.RAM("32GB"); // ✗ does not compile — INeedsCpu has no RAM()
```

Explicit interface implementation keeps `PCBuilder` itself from exposing any of these methods publicly — only the interface types do, and each interface type only offers the one next step. The ordering is enforced by what's *visible* at each point in the chain, not by any runtime check.

These two patterns solve opposite problems; pick the one matching the actual requirement rather than forcing one shape to do both:

| Requirement | Pattern |
| --- | --- |
| Any order, all facets always reachable | Recursive generic (flat form) |
| Fixed order, steps gated one at a time | Step Builder (interfaces) |

## Cost

Unreadable to anyone who hasn't seen the trick. Generic constraint errors are cryptic. Even the correct (flat) form gets unwieldy past \~3–4 facets. Reserve this for library-grade APIs where order-independent fluent chaining is a hard requirement. For an ordinary POCO, a plain linear builder is simpler, safer, and just as usable.