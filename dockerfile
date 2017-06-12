FROM microsoft/dotnet:latest
ENV ASPNETCORE_URLS=http://+:5000
COPY ./src /app
WORKDIR /app/campanhabrinquedo.webapi
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
EXPOSE 5000/tcp
ENTRYPOINT ["dotnet","run"]