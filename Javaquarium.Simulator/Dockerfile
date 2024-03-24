FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Javaquarium.Simulator/Javaquarium.Simulator.csproj", "Javaquarium.Simulator/"]
RUN dotnet restore "Javaquarium.Simulator/Javaquarium.Simulator.csproj"
COPY . .
WORKDIR "/src/Javaquarium.Simulator"
RUN dotnet build "Javaquarium.Simulator.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Javaquarium.Simulator.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Javaquarium.Simulator.dll"]
