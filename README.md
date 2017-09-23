# campanhabrinquedo_core

## curl comand

```#!/bin/bash
 curl -method POST -body 'username=TEST&password=TEST123' -uri http://localhost:5000/api/token
```

## Up docker Data Server

```#!/bin/bash
 docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=yourStrong(!)Password' -p 1433:1433 -d microsoft/mssql-server-linux´
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