# OpsHub

An internal IT operations hub: roaming requests, device register and configurable dynamic tables.

## Tech stack
ASP.NET Core (.NET 10) · EF Core · Azure SQL · Next.js · TypeScript · Tailwind CSS · Microsoft Entra ID · Azure Container Apps · GitHub Actions

## Structure
```
src/
  OpsHub.Domain/          Entities, value objects, domain rules (no dependencies)
  OpsHub.Application/     Use cases, DTOs, interfaces (→ Domain)
  OpsHub.Infrastructure/  EF Core, Microsoft Graph, external services (→ Application)
  OpsHub.Api/             HTTP endpoints, authN/authZ, DI composition (→ Application, Infrastructure)
tests/
  OpsHub.UnitTests/
  OpsHub.IntegrationTests/
web/                      Next.js frontend
```

## Running locally

Backend:
```bash
dotnet build
dotnet test
dotnet run --project src/OpsHub.Api
```

Frontend:
```bash
cd web
npm install
npm run dev     # http://localhost:3000
```
