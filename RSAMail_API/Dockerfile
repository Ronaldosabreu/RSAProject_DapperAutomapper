#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["RSAMail_API/RSAMail_API.csproj", "RSAMail_API/"]
RUN dotnet restore "RSAMail_API/RSAMail_API.csproj"
COPY . .
WORKDIR "/src/RSAMail_API"
RUN dotnet build "RSAMail_API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RSAMail_API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RSAMail_API.dll"]