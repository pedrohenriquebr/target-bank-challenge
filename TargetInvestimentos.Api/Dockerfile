#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TargetInvestimentos.Api/TargetInvestimentos.Api.csproj", "TargetInvestimentos.Api/"]
RUN dotnet restore "TargetInvestimentos.Api/TargetInvestimentos.Api.csproj"
COPY . .
WORKDIR "/src/TargetInvestimentos.Api"
RUN dotnet build "TargetInvestimentos.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TargetInvestimentos.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TargetInvestimentos.Api.dll"]