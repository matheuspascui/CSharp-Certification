## Creating a .NET Project in VSCode

To be able to create a project in VSCode using .NET, there are some requirements:
- VSCode with C# Dev Kit Extension installed
- .NET SDK installed

.NET supports some CLI commands. To use them, type `dotnet` followed by the type of the command. Commands: 

- `dotnet new` :arrow_right: to create a new type of project. Following the `new`, we specify the type of project, like an ASP.NET Core, a console, etc.
- `dotnet new console` :arrow_right: the most used from now on, to create CLI applications with .NET. If we pass the option `-o C:/Users/User/Projects`, we are telling to the dotnet to create a proejct in the specified folder. If we don't pass the destination folder of the project, **it'll be created on the actual folder.**
- `dotnet build` :arrow_right: executes the building process of our project. Compiling to the bytecode of IL (intermediary language).
- `donet run` :arrow_right: runs our project. If we write the program and type the `run`, it will automatically build AND run.