# Stepwise Builder (Step Builder)

Also known as: Staged Builder, Interface-Segregated Builder.

## Goal

Force construction steps to happen in one fixed, compiler-enforced order. This is the opposite goal of the recursive generic (CRTP) fluent builder — that one maximizes freedom of call order; this one eliminates it.

## Problem it solves

A plain fluent builder (one class, every setter returns `this`) lets any step be skipped, repeated, or called out of order, and lets `Build()` be called before required fields are set. Those mistakes only surface at runtime — a null/empty field, or manual validation you have to remember to write in `Build()`. The step builder turns an invalid call sequence into a compile error instead.

## Core mechanism

- One interface per construction step. Each interface exposes exactly one method, and that method's return type is the *next* step's interface — never the current type, never an earlier step's type.
- The final interface in the chain exposes only `Build()`.
- A single class implements every step interface and holds the product's state as it accumulates across calls.
- The only way to obtain the first step's interface is through a static entry point on a dedicated builder class, which returns that first interface type and keeps the concrete implementing class out of view entirely.

## Players

- **Step interfaces** — a strict sequence, each exposing one step, down to a final interface that exposes only `Build()`. Siblings to each other; no inheritance between them.
- **Concrete implementation** — one class implementing every step interface, holding/accumulating the product's state.
- **Entry point** — a static method or property returning the first step's interface.
- **Product** — the finished object `Build()` returns.

## Nuances

- **Implicit vs. explicit interface implementation.** Explicit implementation hides every step method from the concrete class's own public surface, so the method is only reachable through the interface type. When the implementing class is already `private`, implicit implementation gives the same practical safety — nothing outside the containing class can ever name the concrete type, so there's no surface to call the wrong method on regardless.
- **Enforcing order costs nothing from generics.** This gets the same "impossible to misuse" guarantee as the CRTP pattern, but through plain interface visibility and a hidden implementing type — no self-referential type parameters, no unsafe cast, no F-bounded constraints.
- **Mutable vs. immutable product.** If the builder mutates a long-lived product instance step by step, the product's properties need setters, which leaves the finished object mutable after `Build()` returns. The alternative is to stage raw values inside the builder and construct the product exactly once, inside `Build()`, in a single initialization expression — which then allows init-only properties on the product. This is a deliberate design decision, not a side effect of how the builder happens to be written.
- **Optional steps.** A step's method can return its own interface again instead of advancing, to allow that step to repeat before moving on. A step that's skippable without being repeatable is awkward: one method can't cleanly offer "either this interface or that one" as its return type, so skippable steps usually need a branching interface or an extra overload at the gate before them.

## Comparison with the recursive generic builder

|  | Step Builder | Recursive Generic (CRTP) Builder |
| --- | --- | --- |
| Call order | Enforced, fixed | Free, any order |
| Mechanism | Sibling interfaces, next-step return types | Self-referential generic `TSelf` |
| Safety | Compiler-enforced via type visibility | Convention + unchecked cast |
| Readability | High — one interface per step, reads top to bottom | Low — requires understanding F-bounded generics |
| Fits | A required, ordered configuration sequence | A set of optional, order-independent facets behind one fluent surface |

## Cost

Boilerplate scales linearly with step count — one interface per step, each wired up once in the implementation. Making a step genuinely optional, rather than just repeatable, needs extra interface branching, which gets unwieldy fast. Not reflection- or serialization-friendly, same as any interface-heavy design.