# SimpleApi - .NET Core Time API

## Overview
SimpleApi is a simple .NET Core Web API that provides a current time endpoint.

## Prerequisites
- .NET 8.0 SDK
- Docker (optional)

## Running the Application

### Using .NET CLI
```bash
cd SimpleApi
dotnet restore
dotnet run
```
### Using Docker
#### Build the Docker image
```bash
docker build -t simpleapi .
```

#### Run the Docker container
```bash
docker run -d -p 5000:8080 --name simpleapi-container simpleapi
```

##### This will:
- Build the Docker image
- Run the container
- Map the container's port 8080 to host port 5000
- Allow you to access the API at http://localhost:5000/api/time


# API Endpoints
GET /api/time: Returns the current server time

# Technologies
.NET 8.0
ASP.NET Core Web API
Swagger/OpenAPI

# Development
Clone the repository
Restore dependencies: dotnet restore
Run the application: dotnet run

# Deployment
The application can be deployed using:

Kestrel server
Docker
Cloud platforms supporting .NET Core