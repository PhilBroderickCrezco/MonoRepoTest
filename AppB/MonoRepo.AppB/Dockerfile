FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["MonoRepo.AppB/MonoRepo.AppB.csproj", "MonoRepo.AppB/"]
RUN dotnet restore "MonoRepo.AppB/MonoRepo.AppB.csproj"
COPY . .
WORKDIR "/src/MonoRepo.AppB"
RUN dotnet build "MonoRepo.AppB.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MonoRepo.AppB.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MonoRepo.AppB.dll"]
