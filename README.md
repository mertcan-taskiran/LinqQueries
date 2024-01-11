# LINQ QUERIES (C#)

## .Net Core - ORM - Entity Framework - LINQ QUERIES (C#)

## Working with single table and multiple tables in Northwind database

> Run the following commands:

### New .Net Project
```
dotnet new console
```

### Database Provider
```
dotnet add package Pomelo.EntityFrameworkCore.MySql
```

### Scaffolding Database
```
dotnet ef dbcontext scaffold "server=localhost;port=3306;database=northwind;user=root;password=password;" "Pomelo.EntityFrameworkCore.MySql" --output-dir "Data/EfCore" --context NorthwindContext
```