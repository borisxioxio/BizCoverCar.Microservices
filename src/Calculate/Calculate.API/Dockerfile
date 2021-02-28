#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["src/Calculate/Calculate.API/Calculate.API.csproj", "src/Calculate/Calculate.API/"]
RUN dotnet restore "src/Calculate/Calculate.API/Calculate.API.csproj"
COPY . .
WORKDIR "/src/src/Calculate/Calculate.API"
RUN dotnet build "Calculate.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Calculate.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Calculate.API.dll"]