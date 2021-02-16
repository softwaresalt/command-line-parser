# Command Line Parser

![Command Line Parser Logo](./docs/images/Banner.png "Command Line Parser Logo")

A simple, light-weight, .NET Core parser for command line arguments, which makes it possible to access parameters
from the command line via well-defined .NET data structures.

## Using the Project

You can always get the latest stable version from NuGet:

```bash
Install-Package Salt.System.CmdLineArgs.Parser.Core --version 1.0.0	# Using the Visual Studio Package Manager
dotnet add package Salt.System.CmdLineArgs.Parser.Core --version 1.0.0	# Using the .NET Command Line Interface
paket add Salt.System.CmdLineArgs.Parser.Core --version 1.0.0		# Using the packet Command Line Interface
```

This project was built using Visual Studio 2019 and .NET Core 3.1. To build the solution, clone the repository
and build it in Visual Studio or using the command line tools of .NET Core:

```bash
git clone https://github.com/softwaresalt/command-line-parser-core
cd command-line-parser-core
dotnet build
dotnet test ./test/System.CommandLine.Parser.Tests.csproj
```

## Contributions

I always greatly appreciate feedback and bug reports. To file a bug, please use GitHub's issue system.
Alternatively, you can clone the repository and send me a pull request.
