# Portfolio Platform

A full-stack portfolio platform built with Angular and ASP.NET Core to showcase projects, software development, testing strategy, and CI/CD practices.

## Deployment
https://bennet-steem.vercel.app/

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

## Testing Strategy

I used a layered testing approach:

- **Backend unit tests** verify service logic and business rules in isolation
- **Backend integration tests** verify API endpoints and HTTP responses
- **Frontend end-to-end tests** use Playwright to validate real user flows through the UI

## Continuous Integration Pipeline

This project uses GitHub Actions to automatically validate changes on push and pull request.

The CI workflow:
- restores and builds the ASP.NET Core backend
- runs backend unit and integration tests
- installs and builds the Angular frontend
- runs Playwright end-to-end tests against the running full-stack application

This helps ensure code quality and protects the main branch from regressions.
