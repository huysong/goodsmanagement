FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["GoodsManagement/GoodsManagement.csproj", "GoodsManagement/"]
RUN dotnet restore "GoodsManagement/GoodsManagement.csproj"
COPY . .
WORKDIR "/src/GoodsManagement"
RUN dotnet build "GoodsManagement.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GoodsManagement.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GoodsManagement.dll"]
