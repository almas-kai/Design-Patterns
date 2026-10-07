# Recursive Generic Fluent Builder
Also known as CRTP-style builder (Curiously Recurring Template Pattern) / F-bounded polymorphism builder.

The goal is to preserve full fluent chaining across a builder inheritance hierarchy, so that calling a method from a base builder still returns a type exposing every derived builder's methods — regardless of call order.

The pattern is useful when:
  1. You need a single fluent chain to support step methods contributed by multiple levels of a builder hierarchy (e.g. `Called(...).WorksAsA(...)`), not just the ones on the leaf class.
  2. A plain fluent builder would normally "forget" derived methods once a base method is called, because the base method's return type is the base type.
## Players
   * Root builder — holds the actual product instance and exposes Build().
   * Intermediate builders — each contributes one group of fluent methods (a "facet" of construction), parameterized by a generic TSelf.
   * Leaf builder — the concrete, non-generic builder the client actually instantiates; closes the generic chain.
   * Client — starts from the leaf builder's entry point and chains methods in any order.
## Nuances
  * Each intermediate builder is generic over `TSelf`, and each level in the hierarchy passes itself wrapped around `TSelf` to its base class — this is what keeps the return type "aware" of the whole chain.
  * Every fluent method casts this to `TSelf` and returns it.
  * Correct, but expensive: reads poorly, hard to extend, hard to debug generic constraint errors. Reserve it for genuine library APIs where call-order-independent chaining is a hard requirement — not for ordinary POCOs.