# campanhabrinquedo_core

#curl comand  
```
 curl -method POST -body 'username=TEST&password=TEST123' -uri http://localhost:5000/api/token
```

#up docker Data Server

```
 docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=yourStrong(!)Password' -p 1433:1433 -d microsoft/mssql-server-linux´
```

#add new reference to Project
```
 dotnet add [Project.csproj] reference [Project Reference.csproj]
```

#add project to solution
```
 dotnet sln [solutionname.sln] add [project.csproj]
```

