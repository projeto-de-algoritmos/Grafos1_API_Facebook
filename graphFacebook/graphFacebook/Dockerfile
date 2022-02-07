#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["graphFacebook/graphFacebook.csproj", "graphFacebook/"]
RUN dotnet restore "graphFacebook/graphFacebook.csproj"
COPY . .
WORKDIR "/src/graphFacebook"
RUN dotnet build "graphFacebook.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "graphFacebook.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "graphFacebook.dll"]