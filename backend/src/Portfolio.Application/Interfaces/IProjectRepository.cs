using Portfolio.Domain.Entities;

namespace Portfolio.Application.Interfaces;

public interface IProjectRepository
{
    Task<IReadOnlyList<Project>> GetAllAsync();
}