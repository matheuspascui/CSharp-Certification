## Storing, Retrieving Data and Variables

If i want to display a message that does not change, i need a literal value, or a **constant**. Every time a specific event occurs and fires that message, the message is the same.

Some kinds of data are hard-coded into the program, that is, they are "constans", its value is already stored in the code. In other cases, the user might be able to input some data and the program needs to store it for later use.

- Literal Value :arrow_right: is a constant value, it never changes.

- char :arrow_right: the char (short for "character") is a data type that stores a single alphanumeric character. To assign its value, we use the single quotes ('').
-int :arrow_right: the **int literal** is used when we want to use an integer, a whole number, NO FRACTIONS! They do not need single or double quotes.
- float :arrow_right: Floating-Point numbers are numbers that contain a decimal portion. In C#, there are 3 data types, each one with its level of precision. The **float** has around 6-9 digits of precision. **Precision** refers to the quantity of numbers PAST the decimal that are accurate. To show to the compiler that we want to work with a float value, we must to add a "F" or "f" to the end of the number, after the decimal part. Float is to be used when we work with **fixed fractional values**
- double :arrow_right: has around 15-17 digits of precision. For the double, we need to append a "D" or a "d" to indicate that the value is of type double. When typing a decimal number without the indicator, the **literal suffix** (f or d), the compiler assigns it to a double, by default.
- decimal :arrow_right: has 28-29 digits of precision. For the decimal, the literal suffix is the letter 'm', appended at the end of thye number.
- bool :arrow_right: the bool are short for the Boolean types in C#, that can be `true` or `false`.

**OBS:** It is best practice to store numerical and boolean values as Strings instead of Decimals, Integers or actual Booleans. Make this to values that are not processed nor used in calculations. If the fields and data are used in calculations, it's better to store them in the int, decimal, boolean forms instead of Strings.

Hard-coded values, or **CONSTANTS** are used for values that we will use and **DO NOT CHANGE** in the program. However, when coding, it is almost 100% sure that we will need some fields that we do not have the values beforehand. For this cases, we use the **Variables**.

Variables are container that store type values. Based on the type of the variable, the memory needed to store it will be different.
They can be assigned, read and changed. For the compiler, variables are memory addresses. We use variables for humans to be able to read the code and rapidly identify the type and name of it, instead of using memory addresses with hexadecimal numbers.
To declare a variable:
- first declare its type
- declare its name

We can declare a variable and after assign a value to it or just initialize the variable with its declaration and initialization with its value. 

- **ASSIGNING** is attributing the value to a variable. It's a **SET operation**.
- **RETRIEVING** is getting the value of the variable. It's a **GET operation**.

I must first SET the value of the variable Before GET this value. If i create a variable firstName and code the Console.WriteLine(firstName) BEFORE assigning a value to firstName, it'll throw an error.
Now, if we type `string firstName = "Bob";`, we **initialized** the variable, by declaring and providing its inital value.

### Implicitly Typed Local Variables

The C# Compiler works behind the scenes trying to understand the code. By initializing a variable with the keyword `var`, the compiler tries to infer the variable's type withou we declaring it. Example:
```C#
var message = "Hello, World!";
```

The `var` keyword tells the compiler that the data type is **implied** from the value assigned. After, the variable has the behaviour of the data type assigned by the compiler as if it was declared normally.

**OBS:** the Value of a variable can change, BUT in C#, the DATA TYPE DOES NOT CHANGE. It's locked in at the time of its declaration.

Because the inner working of the `var` variables, they MUST be initialized, for the compiler to imply its type.