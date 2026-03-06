using Portfolio.Application.DTOs;
using Portfolio.Application.Interfaces;

namespace Portfolio.Application.Services;

public class ProfileService : IProfileService
{
    private readonly IProfileRepository _profileRepository;

    public ProfileService(IProfileRepository profileRepository)
    {
        _profileRepository = profileRepository;
    }

    public async Task<ProfileDto> GetAsync()
    {
        var profile = await _profileRepository.GetAsync();

        return new ProfileDto
        {
            Name = profile.Name,
            Headline = profile.Headline,
            About = profile.About,
            Email = profile.Email,
            LinkedInUrl = profile.LinkedInUrl,
            GitHubUrl = profile.GitHubUrl,
            PhotoUrl = profile.PhotoUrl,
            Location = profile.Location
        };
    }
}