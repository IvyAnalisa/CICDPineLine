# Use the official .NET Core runtime as a base image
FROM mcr.microsoft.com/dotnet/runtime:6.0.402 AS base
WORKDIR /app

# Copy the content of the built .NET application
FROM mcr.microsoft.com/dotnet/sdk:6.0.402 AS build
WORKDIR /src
COPY . .

# Build the application
RUN dotnet restore
RUN dotnet publish -c Release -o /app

# Use the base image and copy the built application
FROM base AS final
WORKDIR /app
COPY --from=build /app .

# Specify the command to run when the container starts
CMD ["dotnet", "PersonnummerKontrollApp.dll"]
