FROM mcr.microsoft.com/dotnet/sdk:7.0 AS builder
WORKDIR /src
COPY ./CategoryService.csproj .
RUN dotnet restore CategoryService.csproj
COPY . .
RUN dotnet build CategoryService.csproj -c Debug -o /src/out

FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=builder /src/out .
EXPOSE 80
ENTRYPOINT ["dotnet", "CategoryService.dll"]