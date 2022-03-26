
# Welcome to the Results helpers library

This library contains simple objects which can help with returning values from methods. This objects contain following:
- `Value` - generic type which holds the value being returned, if the operation finished successfully
- `IsSuccess` - bool value indicating if the operation was successful
- `ErrorMessage` - optional error message if defined
- `Exception` - optional exception if defined

## Types of Results

Following are Result type in library:
- `Result` - Generic Result class for class types
- `ValueResult` - Generic Result class for unmanaged types
- `StringResult` - Result class for strings

## Creation of Result instances

Each type of a Result has it's own *creator* static class, which creates instance of it's Result type.
There are following:
- `ResultCreator` - creates instances of `Result` class
- `ValueResultCreator` - creates instances of `ValueResult` class
- `StringResultCreator` - creates instances of `StringResult` class
