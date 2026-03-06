using Portfolio.Application.Interfaces;
using Portfolio.Domain.Entities;

namespace Portfolio.Infrastructure.Repositories;

public class InMemoryProfileRepository : IProfileRepository
{
    public Task<Profile> GetAsync()
    {
        var profile = new Profile
        {
            Name = "Bennet Steem",
            Headline = "Computing Science student building full-stack and AI-driven solutions.",
            About = "I build software, automation, and AI projects with a focus on practical impact.",
            Email = "steem@ualberta.ca",
            LinkedInUrl = "https://www.linkedin.com/in/bennet-steem",
            GitHubUrl = "https://github.com/bsteem",
            PhotoUrl = "/assets/profile.jpg",
            Location = "Edmonton, AB"
        };

        return Task.FromResult(profile);
    }
}