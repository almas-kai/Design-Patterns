# Interpreter Behavioral Pattern

Lets you define a representation for a "language" and interpret the meaning of the "language". In other words, lets you define your own language and work with it.

## Implementation Details

1. Define a base class (or interface) for the different types of expressions of the language you are going to create.
2. Define concrete expressions. The most basic expression is called the terminal expression (leaf node). Others are non-terminal ones.
3. Define a context class that holds all the necessary information about the entire 'sentence', which is composed of individual expressions.
4. The client code must create the AST (abstract syntax tree), basically a tree that has different types of nodes as different types of expressions.
5. The client code must call the method that interprets the AST.

## Pros

1. SRP is respected. The context class has one purpose holding all the necessary info, the nodes are expressions that can interpret themselves.
2. OCP is respected. You can introduce new expressions without altering the existing ones.
3. You can create your own domain-specific languages, though this pattern is best suited for simpler languages.

## Cons

1. Performance and maintainability can be a problem if your language is complex.

## Use Cases

1. When you need to create a domain specific language you can use this pattern to work with that language.
2. When you need to evaluate mathematical expressions.
3. For processing simple config data.
