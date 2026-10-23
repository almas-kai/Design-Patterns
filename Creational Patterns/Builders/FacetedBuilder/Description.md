# Faceted Builder

Also known as: Composition Builder, Non-Generic Order-Free Builder.

## Goal

Let any facet of construction be reached in any order, any number of times, from a single fluent chain — the same end goal as the recursive generic (CRTP) builder — without generics, self-referential type parameters, or an unchecked cast.

## Problem it solves

The CRTP recursive-generic builder gets order-free chaining by having every level cast an inherited `this` back to a self-type, trusting that the chain was closed correctly — a convention enforced by discipline, not the compiler. A faceted builder gets the identical freedom through plain inheritance and composition instead: every facet exposes the same navigation to every other facet because they all inherit it from one shared base, with no generic parameter and no cast involved anywhere.

## Core mechanism

- A single base class holds the one product instance under construction, plus one navigation property per facet.
- Each navigation property, when accessed, constructs a new instance of that facet's class and passes along the *current* product instance, so the facet operates on the same object rather than a fresh one.
- Each facet class inherits the base directly, so it automatically has every other facet's navigation property available too — no facet needs to redeclare these.
- A facet's own methods live only on its own class, mutate the shared product directly, and return that facet instance for further chaining within it, or any navigation property to jump elsewhere.
- The finished product is obtained either through an explicit build method, or through an implicit conversion from the base type to the product type, letting the final expression in the chain be assigned directly as the product.

## Players

- **Product** — the object under construction; must be a reference type, since every facet mutating it needs those mutations visible through every other facet holding the same reference.
- **Base builder** — holds the product and declares the navigation properties to every facet; never generic.
- **Facet builders** — each inherits the base directly; contributes its own group of fluent setter methods, all acting on the one shared product.
- **Navigation properties** — one per facet, declared once on the base, inherited everywhere; responsible for wrapping the *existing* product in a new facet instance, never a fresh product.

## Nuances

- **The product must be created exactly once**, by whichever constructor is the real entry point, and handed down to every facet through that facet's own constructor — never recreated inside a facet. A facet that accidentally constructs its own fresh product instance instead of receiving the shared one silently detaches its edits from whatever the build step eventually returns, with no error to reveal it.
- **A navigation property that constructs its facet on every access, rather than caching it, is expected, not a bug.** Every such access produces a new facet wrapper object, and that's fine — all of them share the same underlying product, so only the product's identity matters, never the wrapper's.
- **No generic self-type means no equivalent of the CRTP cast risk.** A facet class here is an ordinary, concrete subclass; every return type is fully verified by the compiler at every step. There's no leap of faith anywhere in this pattern.
- **An implicit conversion from the builder to the product is a legitimate way to obtain the result**, but implicit conversions in general are easy to trigger unintentionally. An explicit build method as the primary, documented way to finish the chain is the safer default, with the conversion kept as a secondary convenience at most.

## Comparison with the recursive generic builder

|  | Faceted Builder | Recursive Generic (CRTP) Builder |
| --- | --- | --- |
| Mechanism | Inheritance and composition, no generics | Self-referential generic type parameter |
| Safety | Fully compiler-verified, no casts | Convention plus an unchecked cast |
| Readability | High — ordinary inheritance, easy to step through | Low — requires understanding F-bounded generics |
| Adding a new facet | One more facet class, one more navigation property on the base | One more generic level, re-deciding the wrapped-vs-flat shape each time |
| Sharing state across facets | Explicit — the product is passed through every facet's constructor | Implicit — every facet operates on the same inherited field automatically |

## Cost

A facet instance is allocated on every navigation access — harmless in cost, but a reminder that facet-wrapper identity should never be compared or relied on, only the shared product's identity. The base class's set of navigation properties has to be kept in sync by hand as facets are added or removed; nothing enforces that every facet actually stays reachable from the base. The "pass the existing product through, never construct a new one" discipline still has to be applied correctly at the root — the pattern doesn't eliminate that requirement, it just requires satisfying it once instead of at every level of a generic chain.