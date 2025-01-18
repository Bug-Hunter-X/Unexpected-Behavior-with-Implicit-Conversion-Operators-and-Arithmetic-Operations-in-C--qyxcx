# Unexpected Behavior with Implicit Conversion Operators and Arithmetic Operations in C#

This example demonstrates a potential issue with implicit conversion operators in C# when used with arithmetic operations.  The implicit conversion from `MyClass` to `int` and vice versa can lead to unexpected results, specifically when performing operations directly on the converted type.

## Problem Description
The `MyClass` defines implicit conversion operators to and from `int`.  While seemingly straightforward, adding an integer to a `MyClass` object (after implicit conversion to `int`) does not behave as one might expect.

## Solution
The solution is to carefully consider the order of operations and avoid implicit conversions when performing calculations involving custom types. Explicit casting can improve clarity and prevent unintended behavior.  Alternatively, overload arithmetic operators within the custom class for more predictable results.