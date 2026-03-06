using Portfolio.Application.DTOs;

namespace Portfolio.Application.Interfaces;

public interface IProfileService
{
    Task<ProfileDto> GetAsync();
}