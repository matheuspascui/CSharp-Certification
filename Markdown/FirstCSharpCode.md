## First CSharp Code

This modules, composed of 7 units has the main purpose of teach me to write the 1st CSharp code. It is a simple "Hello World".

- Difference between Console.WriteLine() and Console.Write()

`Console.WriteLine()` :arrow_right: this method adds a line at the end of the output (my message, in this case, "Hello, World!"). It is similar when someone presses enter after a message.
`Console.Write()` :arrow_right: this method prints the message to the output console, but id DOES NOT adds a line after the message. In this way, it is possible to add more than 1 message in the same line.


### How it works

Here, some presentation about C# syntax and how the language was designed.

- literal string :arrow_right: is the string with the message "Hello, World!". It is a literal because i want exactly those letters in that specific order to be printed in the output console. 
- Console :arrow_right: is a Class. Classes "own" methods, or the methods live inside a Class. In this case, all the methods that operate in the console are inside the Console Class.
- Period :arrow_right: the period (.) that separates the Console from the WriteLine is a **member access operator**, meaning that using it is how i can access the Class' methods.
- WriteLine() :arrow_right: is a method. Each method has **ONE** job. For the WriteLine(), its job is to write a line of data in the output console. Methods can be spot by the set of parentheses used at the end of their names, like the WriteLine(). Some methods need **input parameters**, given inside their parentheses, others don't. To invoke (or call) a method, we use the parentheses, which are called **method invocation operator**.
- Semicolon :arrow_right: the semicolon ";", is the **end of statement operator**. A **statement** is a complete instruction in C#. The semicolon tells the compiler that i've finished entering the command.

### Flow of Execution

The code is executed one line at a time and sequentially, as the code is written. There are some instructions that are able to change the execution flow.

