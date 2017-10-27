# campanhabrinquedo_core

## curl comand

```#!/bin/bash
 curl -Method POST -body '{"usuario":"user","senha":"password"}' -uri http://localhost:5000/api/usuario/token -ContentType application/json
```

## Up docker Data Server

```#!/bin/bash
 docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=yourStrong(!)Password' -p 1433:1433 -d microsoft/mssql-server-linux:2017-latest
```

## Add new reference to Project

```#!/bin/bash
 dotnet add [Project.csproj] reference [Project Reference.csproj]
```

## Add package to project

```#!/bin/bash
dotnet add package [PackageName]
```

## Add project to solution

```#!/bin/bash
 dotnet sln [solutionname.sln] add [project.csproj]
```

## Documentation of api

<http://localhost:5000/swagger/>

## Technology

* [.NET Core](https://www.microsoft.com/net/core)
* [Swagger](https://swagger.io/)
* [Docker](https://www.docker.com/)
* [Sql Server](https://www.microsoft.com/en-us/sql-server/sql-server-2017)
* [Entity Framework Core](https://docs.microsoft.com/en-us/ef/#pivot=efcore)
* [Auto Mapper](http://automapper.org/)
* [FluentValidation](https://github.com/JeremySkinner/FluentValidation)