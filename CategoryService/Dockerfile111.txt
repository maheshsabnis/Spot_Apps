#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.
# The BASE ASP.NET COre 7.0 Image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
# The Directory that will contain the BUild Output in the Image
WORKDIR /app
# PORTs exposed by the Container for HTTP (80) and HTTPS (443) access
EXPOSE 80
EXPOSE 443
#  The .NET 7 SDK that will be used to BUid the Application inside the Image 
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
# The Dependencies FOlder in the IMage
WORKDIR /src
# COpy the Project file to the image so that the MSBuid will be ivoked by VS to
# Create application Build in the image 
COPY ["CategoryService/CategoryService.csproj", "CategoryService/"]
# THe Version Dependencies will be Restored using MSBuild
RUN dotnet restore "CategoryService/CategoryService.csproj"
# Copy files like appsettings.json and other necessary files (with folder structure) in Image
COPY . .
# THe Path changes to CategoryService
WORKDIR "/src/CategoryService"
# The Release Build will be created
RUN dotnet build "CategoryService.csproj" -c Release -o /app/build
# The Publish
# The Application dll file will be loaded for 'dotnet run' command
# and will be ready to accept HTTP Requests on Exposed Ports
FROM build AS publish
RUN dotnet publish "CategoryService.csproj" -c Release -o /app/publish /p:UseAppHost=false
# ASP.NET Core 7.0 Runtime that will be loaded to accept HTTP Requests
FROM base AS final
# From the App folder
WORKDIR /app
COPY --from=publish /app/publish .
# The dll file will be loaded nside the dotnet.exe and will execute
ENTRYPOINT ["dotnet", "CategoryService.dll"]