# Этап 1: Сборка и публикация
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Копируем csproj и восстанавливаем зависимости
COPY ["wt_lab5_5razor_lyashuk.csproj", "./"]
RUN dotnet restore "wt_lab5_5razor_lyashuk.csproj"

# Копируем остальные файлы и собираем проект
COPY . .
RUN dotnet publish "wt_lab5_5razor_lyashuk.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Этап 2: Финальный образ для запуска
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080

ENTRYPOINT ["dotnet", "wt_lab5_5razor_lyashuk.dll"]