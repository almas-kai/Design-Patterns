# Composite Structural Pattern

Composes objects into tree-like structures, and lets clients to work with these objects and tree-like structures in a unified way. So, the client doesn't care if it is working with a "simple" object, or an object that is composed of many other objects.

## Usage Scenario

Use it when your model can be represented as a tree. For instance, you have a "folder" class which may contain other "folder" objects, or "file" objects.

Use the Composite pattern when the tree structure and its operations are more important than the individual elements.

## Terminology

The simple elements of the tree are called leaf-nodes.

The complex elements of the tree are called containers or composites.

## Implementation Steps

1. Create the general interface for both leaf-nodes and container nodes.
2. Create a leaf-node class to represent simple elements. You can declare different types of leaf-nodes.
3. Create a composite-node class to represent complex elements. The class must contain an array-like field that must be able to store both leaf and/or composite nodes (use the interface from the step 1). The container should delegate most of the work to its sub-nodes. Also declare methods that will add/remove nodes to/from the array-like field.

## Pros

1. Work with the tree-like models is simplified.
2. OCP is respected.
