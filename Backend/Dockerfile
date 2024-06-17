# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy solution and project files
COPY *.sln ./
COPY Buylia.API/*.csproj Buylia.API/
COPY Buylia.Application/*.csproj Buylia.Application/
COPY Buylia.Context/*.csproj Buylia.Context/
COPY Buylia.DTO/*.csproj Buylia.DTO/
COPY Buylia.Infrastructure/*.csproj Buylia.Infrastructure/
COPY Buylia.Model/*.csproj Buylia.Model/

# Restore dependencies
RUN dotnet restore

# Copy the entire source code
COPY . .

# Build the project
RUN dotnet publish Buylia.API/Buylia.API.csproj -c Release -o out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Expose the port the application runs on
EXPOSE 50

# Define the entry point for the container
ENTRYPOINT ["dotnet", "Buylia.API.dll"]