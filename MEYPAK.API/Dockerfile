#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NuGet.config", "."]
COPY ["MEYPAK.API/MEYPAK.API.csproj", "MEYPAK.API/"]
COPY ["MEYPAK.BLL/MEYPAK.BLL.csproj", "MEYPAK.BLL/"]
COPY ["MEYPAK.DAL/MEYPAK.DAL.csproj", "MEYPAK.DAL/"]
COPY ["MEYPAK.Entity/MEYPAK.Entity.csproj", "MEYPAK.Entity/"]
COPY ["MEYPAK.Interfaces/MEYPAK.Interfaces.csproj", "MEYPAK.Interfaces/"]
RUN dotnet restore "MEYPAK.API/MEYPAK.API.csproj"
COPY . .
WORKDIR "/src/MEYPAK.API"
RUN dotnet build "MEYPAK.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MEYPAK.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MEYPAK.API.dll"]