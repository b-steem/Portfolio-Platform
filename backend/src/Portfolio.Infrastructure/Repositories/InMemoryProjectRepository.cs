using Portfolio.Application.Interfaces;
using Portfolio.Domain.Entities;

namespace Portfolio.Infrastructure.Repositories;

public class InMemoryProjectRepository : IProjectRepository
{
    private readonly List<Project> _projects =
    [
        new()
        {
            Id = 1,
            Title = "RL Market Analysis",
            Description = "A reinforcement learning market analysis app with interactive dashboards.",
            TechStack = ["Python", "Streamlit", "Pandas"],
            GitHubUrl = "https://github.com/b-steem/rl-market-analysis",
            LiveUrl = "",
            ImageUrl = "",
            Featured = true,
            DisplayOrder = 1
        },
        new()
        {
            Id = 2,
            Title = ".NET Portfolio Platform",
            Description = "A full-stack portfolio platform built with Angular and ASP.NET Core.",
            TechStack = ["Angular", "ASP.NET Core", "C#", "Playwright"],
            GitHubUrl = "https://github.com/b-steem/portfolio-platform",
            LiveUrl = "",
            ImageUrl = "",
            Featured = true,
            DisplayOrder = 2
        }
    ];

    public Task<IReadOnlyList<Project>> GetAllAsync()
    {
        return Task.FromResult<IReadOnlyList<Project>>(_projects);
    }
}