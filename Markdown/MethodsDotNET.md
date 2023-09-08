## Calling Methods from the .NET Class Library

To build more useful code, we need the .NET Runtime and the .NET Class Library. The Runtime hosts and manages the code as it runs it. The Class Library is a collection of prewritten coding resources.

In the same way when we need a book we go to a library and search for a book that fit our needs, the analogy is the same for code libraries. A library is an organized collection of code resources. The .NET Class Library is, as the name says, a library containing thousands of Classes, with tens of thousands of methods for a developer to use.
For example the `Console` class, that we use when creating Console applications. The methods that we already used within this class are `WriteLine()` and `Write()`.

A Class can be like a container for methods, where methods with similar functions are grouped in the same Class. For example, there are various classes to build Web Applications, build native desktop apps and access a database.

### Data Types

Even some data types are provided with classes within .NET, like `strings` and `int`. This approach provides some types with valuable and useful methods for day-to-day use.

### Finding the Needed Methods/Classes

To find the needed Classes or methods, use the C# Documentation, Google and developer blogs. Search for the task that needs to be completed and, thus, find the class/method that enables it.

### Calling Methods from the .NET Class Library

Using the example of the already known `Console.WriteLine("Hello, World!")` calling:
- type the name of the Class, `Console`, in this case
- add the access operator, the `.` to be able to invoke the method within the Class
- type the method's name, `WriteLine`
- add the invocation operator to the method, the `()`
- pass the arguments if needed, `"Hello, World!"`

## PROGRAMMING

In this section, according to the Microsoft's Tutorial, i created a project folder inside `Code` folder, called `CallMETHODS`. Inside the CallMETHODS i will create the program that will use classes and methods to illustrate the concepts, following instructions from MS.
**Inside the `Program.cs`, i will put some comments to help identify the functions of the code, explaining some concepts of the MS' Tutorial.**

At the `Program.cs` code, it displays 2 different ways of calling a method, because the inner difference in their nature.

There are **Stateful** and **Stateles** methods. The term **state** in software development is used to describe the condition of the execution environment at a specific moment in time. At any moment of the execution of the program, the current state of the aplication is the collection of all values stored in memory.

Some methods don't rely on the current state of the application to work properly, but others do. **Stateless Methods** are implemented so they can work without referencing or changing any values already store in memory. They are also known as **static methods**. For example, the `Console.WriteLine()` method is stateless or static.

Other methods must have access to the state of the application to work properly, they are the **stateful methods**. Also known as **instance methods**, they rely on values stored in memory by the previous lines of code that have already been executed, so they can access this values. They modify the state of the application by changing the values already stored in memory or by adding new ones. A single Class can support both methods, but when you need to use stateful methods, you need to first create an **instance** of the class, so you can access state.

To create an instance of a Class, we use the keyword `new`. An **instance of a class is an object**. As an example, we created an instance of the class Random creating a new object, the `dice`. Code: 
```C#
Random dice = new Ramdon();
```

The `new` operator does important things:
- It requests an address in computer's memory large enough to store an object of the based on the `Random` Class
- It creates the new object and stores it in memory
- It returns the memory address so that it can be saved in the `dice` variable

The `dice` variable is refenrcing this memory address reserved for this new object based on `Random` Class, giving us the illusion that we are working with the `dice` object directly.

OK, BUT WHY THE NEXT() METHOD IS STATEFUL?? WHAT VALUES ARE BEING STORED IN MEMORY?

It's Stateful because of how it works. Let's see.

The `Next()` methods works by capturing **date and time down to fraction of a millisecond**. This data is used to seed an algorithm that generates a "Random" number. The number is based on the algorithm and **is not trully random**. So, the state that is captured and maintained through the object lifetime is the seed value. Each subsequent call to the method, reruns the algorithm with a different date and time, giving a new value (that may or may not be equal to the old value).

**The important thing to know is that i won't always know HOW the methods work, but i MUST know what methods require an Instantiation BEFORE use them.**

:arrow_right: :arrow_right: But HOW do i know what methods need an instance or not? READING the DOCUMENTATION. One TIP based on practical test it to try to access the method directly, as we do with Console.WriteLine(). If the editor shows a red line, that shows us that we CAN'T access directly this method an it requires an instance.