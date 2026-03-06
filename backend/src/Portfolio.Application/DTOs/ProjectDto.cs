namespace Portfolio.Application.DTOs;

public class ProjectDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> TechStack { get; set; } = [];
    public string GitHubUrl { get; set; } = string.Empty;
    public string LiveUrl { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public bool Featured { get; set; }
    public int DisplayOrder { get; set; }
}