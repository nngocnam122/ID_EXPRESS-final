# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj & restore (cache layer)
COPY *.csproj ./
RUN dotnet restore

# Copy all source
COPY . ./

# Publish project (not solution)
RUN dotnet publish Renew_IDLine.csproj -c Release -o /app/out --no-restore


# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app/out .

ENV ASPNETCORE_URLS=http://+:10000
EXPOSE 10000

ENTRYPOINT ["dotnet", "Renew_IDLine.dll"]
