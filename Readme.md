# Simple EF Core + GraphQL

Simple and quick project to show how to quickly link a DB Schema to a GraphQL endpoint using EF Core 

## Getting Started


### Prerequisites


```
Dotnet Core 3.1 SDK
```

### How to use

Clone the repo

```
cd ./Api
```

```
dotnet restore
```

```
dotnet run
```

Access GraphQL Playground at http://localhost:5000/playground and GraphQL Voyager at http://localhost:5000/voyager


### What can I find

#### GraphQL implementation

GraphQL implementation used is [HotChocolate](https://github.com/ChilliCream/hotchocolate)

#### Database

Sample SQLite database found at [SQListeTutoriql.net](https://www.sqlitetutorial.net/sqlite-sample-database/)
Any DBMS with an entityFramework support should work.

#### EF Core

Scaffold done with EF Core Tools

Install it globally with :
```
dotnet tool install --global dotnet-ef
```

Scafold script can be found in `./DB.Models/`


