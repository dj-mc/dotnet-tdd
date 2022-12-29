# dotnet-tdd

```bash
# Project setup
dotnet new sln -o src
dotnet new webapi -o customers.API
dotnet new xunit -o customers.UnitTests
dotnet sln add ./**/*.csproj
```

```bash
cd customers.UnitTests

# Install Moq
dotnet add package Moq --version 4.18.3
# Install FluentAssertions
dotnet add package FluentAssertions --version 6.8.0
```
