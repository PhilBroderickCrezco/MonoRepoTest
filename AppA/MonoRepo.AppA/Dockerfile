FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MonoRepo.AppA/MonoRepo.AppA.csproj", "MonoRepo.AppA/"]
RUN dotnet restore "MonoRepo.AppA/MonoRepo.AppA.csproj"
COPY . .
WORKDIR "/src/MonoRepo.AppA"
RUN dotnet build "MonoRepo.AppA.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MonoRepo.AppA.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MonoRepo.AppA.dll"]
