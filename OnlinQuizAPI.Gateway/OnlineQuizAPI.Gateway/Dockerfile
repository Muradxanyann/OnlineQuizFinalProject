FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["OnlineQuizAPI.Gateway.csproj", "./"]
RUN dotnet restore "OnlineQuizAPI.Gateway.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet build "./OnlineQuizAPI.Gateway.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./OnlineQuizAPI.Gateway.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
# Добавьте эту строку для копирования конфигурационного файла
COPY configuration.json .
ENTRYPOINT ["dotnet", "OnlineQuizAPI.Gateway.dll"]