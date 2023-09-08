## Operations with Numbers

If we use the addition operator `+`, we can perform additions.

In the example below, we perform an implicit type conversion:
```C#
string firstName = "Bob";
int carsSold = 10;
Console.WriteLine(firstName + " vendor sold " + carsSold + " cars.");
```

In this example, the C# Compiler tries to convert the int variable into a string, because it sees that the int is surrounded by two addition (or concatenation operators) of different types. **Ideally, you will indicate any conversion Explicitly**.

We can perform operations inside the `Console.WriteLine()`, by adding parentheses to show our intentions. Example:
```C#
firstName = "Bob";
int carsSold = 10;
Console.WriteLine(firstName + " vendor sold " + (carsSold + 5) "cars this month!");
//The output will show 15 cars being sold, because the compiler first evaluates the expression inside the parenthesis
//and after converts it to a literal string
```

**OBS: AVOID DOING BOTH A CALCULATION AND A STRING CONCATENATION IN THE SAME LINE OF CODE. Microsoft puts this warning. This example is only to indicate what is possible and how the compiler understands this code**

### Basic Arithmetic Operations

Example:
```C#
int sum = 7 + 5; //output = 12
int difference = 7 - 5; //output = 2
int product = 7 * 5; //output = 35
int quotient = 7 / 5; //output = 1, because 7 divided by 5 is 1 with rest 2 
```

In C# the operators are:
- `+` for Addition
- `-` for subtraction
- `*` for multiplication
- `/` for quotient of division
- `%` for the rest of division - tells us if one number is divisible by the other.

Performing a `int` division will only give us a `int` result. To see the decimal portion of the division, we must use some type that supports this kind of operation, like `decimal, float, double`. This way, we perform an exact division. Using the rest operator, we see if one number is divisible by the other.

The famous acronymous PEMDAS reinforce the order of operations:
- Parentheses (what's inside is evaluated first)
- Exponents
- Multiplication (from left to right)
- Division (from left to right)
- Addition (from left to right)
- Subtraction (from left to right)

Another example: 
```C#
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1); //output = 23
Console.WriteLine(value2); //output = 35
```

### Incrementation and Decrementation

To write code where some variable increments or decrements its value, we use some operators:
- `+=` :arrow_right: it adds the value at the right of the operator and assigns it to the variable
- `-=` :arrow_right: it subtracts the value and assigns it to the variable
- `*=` :arrow_right: does the same thing with multiplication
- `++` :arrow_right: performs the same as the `+=`
- `--` :arrow_right: performs the same as the `-=`

Example:
```C#
int value = 2;
value = value + 3; //value is now 5
value += 3; //value is now 8
value ++; //value is now 9
value +=2; //value is now 11
value -= 1; //value is now 10
```

**OBS: ATENTION for the Position of the increment and decrement operators. If the `++` or the `--` is located before the variable, the decrement or increment will happen before the value is retrieved.**

You could also add parentheses to improve readability.