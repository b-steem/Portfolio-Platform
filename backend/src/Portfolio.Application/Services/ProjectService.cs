using Portfolio.Application.DTOs;
using Portfolio.Application.Interfaces;

namespace Portfolio.Application.Services;

public class ProjectService : IProjectService
{
    private readonly IProjectRepository _projectRepository;

    public ProjectService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }

    public async Task<IReadOnlyList<ProjectDto>> GetAllAsync()
    {
        var projects = await _projectRepository.GetAllAsync();

        return projects
            .OrderBy(project => project.DisplayOrder)
            .Select(project => new ProjectDto
            {
                Id = project.Id,
                Title = project.Title,
                Description = project.Description,
                TechStack = project.TechStack,
                GitHubUrl = project.GitHubUrl,
                LiveUrl = project.LiveUrl,
                ImageUrl = project.ImageUrl,
                Featured = project.Featured,
                DisplayOrder = project.DisplayOrder
            })
            .ToList();
    }

    public async Task<IReadOnlyList<ProjectDto>> GetFeaturedAsync()
    {
        var projects = await _projectRepository.GetAllAsync();

        return projects
            .Where(project => project.Featured)
            .OrderBy(project => project.DisplayOrder)
            .Select(project => new ProjectDto
            {
                Id = project.Id,
                Title = project.Title,
                Description = project.Description,
                TechStack = project.TechStack,
                GitHubUrl = project.GitHubUrl,
                LiveUrl = project.LiveUrl,
                ImageUrl = project.ImageUrl,
                Featured = project.Featured,
                DisplayOrder = project.DisplayOrder
            })
            .ToList();
    }
}