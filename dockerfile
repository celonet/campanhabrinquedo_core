FROM microsoft/aspnetcore:2.0
WORKDIR /app
EXPOSE 5000
COPY ./src/campanhabrinquedo.webapi/bin/debug/netcoreapp1.1/publish /app
ENTRYPOINT ["dotnet","campanhabrinquedo.webapi.dll"]