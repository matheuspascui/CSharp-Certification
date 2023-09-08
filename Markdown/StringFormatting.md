## String Formatting

This section will teach me how to format strings, adding special characters as well as escaping characters.

An **escaping character sequencing** is an instruction to the runtime to insert a special character that affects the output of the string. In C#, the escaping character is the backslash "\", followed by the character you're escaping. In this case, `\n` will add a new line, `\t` will add a tab. Example:
```C#
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
```

In the case i need to add a term with double quotes. If i don't use the `\` escape character, the compiler will understand that i ended the string prematurely and will throw an error. To be able to use a double quote term inside a string, simply use the escape character. Example:
```C#
Console.WriteLine("Hello for the \"World\"!");
```

If i need to display a path and use one slash `\`, the compiler will try to understand as an escaping. To effectively make it understand as a `\` for a path route, use `\\` instead. Use 2 backslashes. Example:

```C#
Console.WriteLine("c:\\users\\User\\Documents");
```

Example from the MS Training:

```C#
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
```

### Verbatim String Literal

A Verbatim string literal will keep all whitespace and characters **without the need to escape** the backslash. To create it, use the `@` directive before the literal string. Example:
```C#
Console.WriteLine(@"    c:\source\repos
            this is where your source code goes");
```


### Unicode Escaping

I can also use the `\u` escape sequence to use a four-character code representing some code in Unicode (UTF-16). Example:
```C#
//Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
```

**OBS:** The Windows Command Prompt won't display All Unicode characters, and the ones that aren't supported will be replaced with question marks. Some characters require UTF-32 to be displayed. So, use it depending on what i need.

### String Concatenation

Used when we need to combine a string message with a variable. It uses the **string concatenation operator**, which is the symbol `+`.
Example:
```C#
string firstName = "Bob";
string message = "Hello, " + firstName;
Console.WriteLine(message);
```

In this case, the output would be `Hello, Bob`. Remember to AVOID using intermediary variables and excessive variables. The less, the better. Simplify things.

### String Interpolation

Used more and more to combine string literals and variables into a single formatted message.
An **interpolation expression** is a variable surrounded by an opening and closing curly brace, `{}`. The literal string becomes a template when prefixed by the `$` symbol. Example:
```C#
//Instead of using this:
string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";

//Do this:
string firstName = "Bob";
string message = "Hello";
string message = $"{greeting} {firstName}";
```

This is cleaner than adding intermediary strings with spaces, punctuation, etc and the result is the same.

It is also possible to use verbatim and string interpolation, like in the example:
```C#
string projectName = "Holiday-Project";
Console.WriteLine($@"C:\User\{projectName}");
```

The final exercise:
```C#
string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($@"View English output:
        c:\Exercise\{projectName}\data.txt
{russianMessage}:
        c:\Exercise\{projectName}\ru-RU\data.txt");
```

SOLUTION BY MICROSOFT:
```C#
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
```

