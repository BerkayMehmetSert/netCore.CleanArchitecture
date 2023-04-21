# Net Core Clean Architecture

This is an example project that demonstrates how to use Clean Architecture with .NET 6.0.

## Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

## Getting Started

1. Clone the repository

```bash
git clone https://github.com/BerkayMehmetSert/netCore.CleanArchitecture.git
```

2. Open the solution in Visual Studio or your preferred IDE

3. Run the application by pressing **F5** or by clicking the **Run** button


## Technologies

- .NET 6.0
- Entity Framework Core
- Entity Framework Core InMemory
- AutoMapper
- FluentValidation
- MediatR

## Project Structure

- **Domain**: Contains the entities, value objects, and domain services.

- **Application**: Contains the application logic and use cases.

- **Persistence**: Contains the database context and the repositories.

- **API**: Contains the ASP.NET Core Web API project.
