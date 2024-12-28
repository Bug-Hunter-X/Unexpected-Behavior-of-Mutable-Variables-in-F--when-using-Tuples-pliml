# F# Mutable Variable Behavior with Tuples

This example demonstrates unexpected behavior when using mutable variables in F# within functions that take tuples as arguments.

## Bug

The `swap` function correctly swaps the values of two mutable variables. However, when a similar approach is used with a tuple, the values are not swapped correctly.  This is because tuples in F# are immutable;  assignment within the function only changes local copies of the values, not the original tuple.

## Solution

The solution involves returning a new tuple with the swapped values instead of attempting to modify the tuple in place.
