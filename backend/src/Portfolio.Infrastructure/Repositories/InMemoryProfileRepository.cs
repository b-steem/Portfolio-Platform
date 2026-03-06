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
            Email = "your-email@example.com",
            LinkedInUrl = "https://www.linkedin.com/in/your-linkedin",
            GitHubUrl = "https://github.com/yourusername",
            PhotoUrl = "/assets/profile.jpg",
            Location = "Edmonton, AB"
        };

        return Task.FromResult(profile);
    }
}