FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish -c Release -o /app

FROM base AS final
COPY --from=build /app .
ENTRYPOINT ["dotnet", "ExpenseTracker.API.dll"]
