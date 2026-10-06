# AutoCare360

AutoCare360 is an enterprise-style Vehicle Service & Claims Management Platform built as an interview-focused portfolio project.

## Vision

Customer → Vehicle → Service Request → Inspection → Estimate → Approval → Repair → Invoice → Payment → Notification → Claim

## Architecture

The project starts as a modular monolith so the core domain and engineering fundamentals can be developed first. Distributed components will be introduced incrementally where they provide a real architectural benefit.

### Planned stack

- C# / .NET 8
- ASP.NET Core Web API
- SQL Server
- Entity Framework Core
- ADO.NET
- Redis
- Kafka / RabbitMQ
- OpenSearch
- Angular
- xUnit + Moq
- Docker
- GitHub Actions

## Repository roadmap

1. Solution foundation and domain model
2. Customer and vehicle management
3. Service requests and repair workflow
4. SQL Server persistence
5. REST API, validation, DTOs, exception handling
6. Authentication and authorization
7. Caching and concurrency
8. Event-driven notifications
9. Search and reporting
10. Automated testing
11. Docker and CI/CD
12. Optional service extraction for distributed architecture

## Engineering goals

This project is intentionally designed to demonstrate practical C#/.NET skills: OOP, generics, collections, LINQ, async programming, dependency injection, SOLID principles, design patterns, SQL, REST APIs, security, logging, testing, concurrency, messaging, caching, observability, and DevOps.

## Status

🚧 Phase 1 — solution foundation
