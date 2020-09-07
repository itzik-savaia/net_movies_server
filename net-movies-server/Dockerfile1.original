#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["SearchMovieServer/net-movies-server.csproj", "SearchMovieServer/"]
RUN dotnet restore "SearchMovieServer/net-movies-server.csproj"
COPY . .
WORKDIR "/src/SearchMovieServer"
RUN dotnet build "net-movies-server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "net-movies-server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ["dotnet", "net-movies-server.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet net-movies-server.dll