# Functional Builder

Also known as: Builder with Deferred Actions, Closure-Based Builder.

## Goal

Build an object by recording a sequence of configuration steps as functions, then replaying them against a fresh instance only when the build step runs — rather than mutating a single held instance as each step method is called.

## Problem it solves

- **Open/Closed extensibility.** If the method that queues a step is exposed widely enough, code outside the builder's own class can add new fluent steps via extension methods, without modifying the builder's source at all.
- **Independent results per build call.** Because building always starts from a brand-new product instance and replays the recorded steps onto it, calling the build step more than once on the same configured builder yields separate, independent objects — not repeated references to one shared, mutated instance.

## Core mechanism

- A generic builder base holds a list of deferred functions, one per queued step, together with the aggregation logic that applies them in order.
- It's also self-referential over the concrete builder type (the same recursive-generic technique as the plain fluent builder), so that queuing a step still returns something exposing every fluent method, supporting chaining through inheritance.
- Each fluent step method on the concrete builder doesn't touch the product at all — it captures its arguments in a closure, appends that closure to the list, and returns itself.
- Only the build step actually constructs the product and folds every recorded closure over it, in order, producing the final object at that single point in time.

## Players

- **Product** — the type being built; needs a parameterless constructor, since a fresh instance is created on every build call.
- **Builder base** — generic over both the product type and the self-type; owns the action list and the fold/aggregate logic.
- **Concrete builder** — the leaf class; its fluent methods just queue closures via the base's step-adding method.
- **Extension methods** *(optional)* — external code adding further fluent steps by calling the base's step-adding method, provided that method's visibility allows it.

## Nuances

- **The self-type cast is inherited, not introduced.** Because the builder base is a recursive generic, nothing in the type system stops a second, mismatched concrete builder from closing the same base incorrectly — the eventual cast back to the self-type is a leap of faith, same as in any CRTP-style builder. Mitigate with a constructor check that verifies the instance really is its own self-type and fails immediately with a clear message, rather than letting a bare cast exception surface later, far from the actual mistake.
- **A value-type product silently breaks the pattern.** Deferred steps act on a product passed into a closure. For a reference type that mutates the real object; for a value type, the closure only ever touches a disposable copy, and the real result never changes — with no exception to reveal it. Constraining the product to reference types removes this failure mode entirely rather than relying on discipline.
- **Step visibility decides whether the complexity is earned.** Exposing the step-adding method broadly buys genuine third-party extensibility. Restricting it to the concrete builder forfeits that, leaving only the fresh-instance-per-build benefit — which a far simpler builder (direct field assignment, one construction expression at build time) achieves just as well, more cheaply.
- **Validation has nowhere to live except at the end.** Steps are just queued closures, not immediate mutations, so no individual step can enforce an invariant as it runs. Any required-field or consistency check has to happen once, after every closure has been applied, at the point the finished product is handed back.

## Comparison

|  | Direct-mutation fluent builder | Functional (deferred-action) builder | Step builder |
| --- | --- | --- | --- |
| When the product is touched | Immediately, per step call | All at once, when building | Immediately, per step call |
| Repeated build calls | Same instance each time | A fresh, independent instance each time | Typically meaningless — the chain itself prevents repeats |
| Step order | Free | Free | Enforced |
| External extensibility | Not inherent | Possible, if the step-adding method is exposed | Not applicable — each step's contract is a fixed interface |

## Cost

A closure allocation and a list entry per step, plus a fold over that list at the end — real indirection compared to writing straight to fields, and overkill for a builder with a handful of simple, non-reused steps. The recursive-generic self-type risk is inherited wholesale from the CRTP builder; going "functional" only changes *when* mutation happens, not that risk. Debugging is also a step removed: a bad value surfaces at build time, inside the fold, one level away from whichever step actually queued it.