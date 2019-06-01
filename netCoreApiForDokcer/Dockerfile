FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["netCoreApiForDokcer/netCoreApiForDokcer.csproj", "netCoreApiForDokcer/"]
RUN dotnet restore "netCoreApiForDokcer/netCoreApiForDokcer.csproj"
COPY . .
WORKDIR "/src/netCoreApiForDokcer"
RUN dotnet build "netCoreApiForDokcer.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "netCoreApiForDokcer.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "netCoreApiForDokcer.dll"]