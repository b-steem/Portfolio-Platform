using Portfolio.Application.DTOs;

namespace Portfolio.Application.Interfaces;

public interface IProjectService
{
    Task<IReadOnlyList<ProjectDto>> GetAllAsync();
    Task<IReadOnlyList<ProjectDto>> GetFeaturedAsync();
}