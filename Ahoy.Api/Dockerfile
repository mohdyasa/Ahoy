#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Ahoy.Api/Ahoy.Api.csproj", "Ahoy.Api/"]
COPY ["Ahoy.Services/Ahoy.Services.csproj", "Ahoy.Services/"]
COPY ["Ahoy.Common/Ahoy.Common.csproj", "Ahoy.Common/"]
COPY ["Ahoy.Repository/Ahoy.Repository.csproj", "Ahoy.Repository/"]
RUN dotnet restore "Ahoy.Api/Ahoy.Api.csproj"
COPY . .
WORKDIR "/src/Ahoy.Api"
RUN dotnet build "Ahoy.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Ahoy.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ahoy.Api.dll"]