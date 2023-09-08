## Arrays

Arrays can be used to store multiple values of **the same type**, in a single variable. For example, a list of student names could be stored in a string array.

Array is a sequence of individual data elements that are similar with each other, holding similar data. They can be accessed by a zero-based numeric index (this means that each element of the array has a numeric index and this index list starts with 0, so the first element will always be 0, not 1).

As the array is a special type of variable that can hold multiple values of the **same type**, the declaration and accessing ways are slightly different.

:exclamation: The code to the exercise proposed by MS is located at the ArraysEXERCISE project folder.

For example of a declaration of an array:
```C#
string[] Orders = new string[5];
```

The `string[]` informs the compiler that the variable `Orders` will be an array of strings, but the `string[5]` is the part that tells that this variable will hold 5 strings within it.

The same way we created an array of strings, we can create arrays of any data types, including primitives, like `int` and `bool` and even more complex data types like Classes.

To assign the values to the array's element, we assign using the `=` symbol, like any other variable. But to access a specific element, we use the 0-based index, like:
```C#
string[] Orders = new string[5];
Orders[0] = "A554";
```

In this piece of code, we accessed the first element of the array (the element with index 0), and assigned a value of "A554" to its string.
