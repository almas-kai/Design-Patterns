# CQRS Pattern

CQRS stands for the *Command Query Responsibility Segregation*. It just means we have 2 different ideas to works with. **Command** for updating data in the DB, and **Queries** for reading data from the DB. Or more formally: CQRS is about separating models and paths for writes (commands) and reads (queries).

Commands and queries represent distinct use cases with different models, rules, and optimizations.

## Implementation Details

1. Define 2 command interfaces (one for the command that returns some result, another is for the command that doesn't return), and 1 query interface. They are actually just for marking.
2. Define 2 command handler interfaces, and one interface for query handler.
3. Implement command interfaces (which just hold data), and handler interfaces, which encapsulate everything from validation, to service usage.
4. You create a command instance, and just call `handle` function.

**Commands**:

* Should always represent intent (for example, `CreateOrder`, not `SaveOrder`).
* May or may not return data.
* Never return query-shaped data.

**Queries**:

* Never mutate state.
* Return DTOs optimized for reads.
* Can bypass domain models entirely.

## Pros and Cons

Pros:

1. Introduces another layer of SRP. **Commands** for changing data. **Queries** for reading data.
2. You can use different DBs for commands and queries.

Cons:

1. Complicates things. For simple CRUDs, you don't need this pattern.
