using Portfolio.Domain.Entities;

namespace Portfolio.Application.Interfaces;

public interface IProfileRepository
{
    Task<Profile> GetAsync();
}