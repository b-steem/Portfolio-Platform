# Portfolio Platform

A full-stack portfolio platform built with Angular and ASP.NET Core to showcase projects, software development, testing strategy, and CI/CD practices.

## Tech Stack
- Angular
- TypeScript
- SCSS
- ASP.NET Core Web API
- C#
- xUnit
- Playwright
- GitHub Actions

## Architecture
- `frontend/` Angular client
- `backend/src/Portfolio.Api` API layer
- `backend/src/Portfolio.Application` application logic
- `backend/src/Portfolio.Domain` domain models
- `backend/src/Portfolio.Infrastructure` infrastructure and persistence
- `backend/tests/Portfolio.UnitTests` unit tests
- `backend/tests/Portfolio.IntegrationTests` integration tests

## Status
Week 6 E2E tests in progress.

## Running the app

### Backend
```bash
cd backend/src/Portfolio.Api
dotnet run
```

### Frontend
```bash
cd frontend
ng serve
```
