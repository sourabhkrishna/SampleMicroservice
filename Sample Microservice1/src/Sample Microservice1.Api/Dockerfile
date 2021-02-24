#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["Sample Microservice1/src/Sample Microservice1.Api/Sample Microservice1.Api.csproj", "Sample Microservice1/src/Sample Microservice1.Api/"]
COPY ["Sample Microservice1/src/Sample Microservice1.Application/Sample Microservice1.Application.csproj", "Sample Microservice1/src/Sample Microservice1.Application/"]
COPY ["Sample Microservice1/src/Sample Microservice1.Domain/Sample Microservice1.Domain.csproj", "Sample Microservice1/src/Sample Microservice1.Domain/"]
COPY ["Sample Microservice1/src/Sample Microservice1.Infrastructure/Sample Microservice1.Infrastructure.csproj", "Sample Microservice1/src/Sample Microservice1.Infrastructure/"]
RUN dotnet restore "Sample Microservice1/src/Sample Microservice1.Api/Sample Microservice1.Api.csproj"
COPY . .
WORKDIR "/src/Sample Microservice1/src/Sample Microservice1.Api"
RUN dotnet build "Sample Microservice1.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sample Microservice1.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sample Microservice1.Api.dll"]