using FluentAssertions;
using Moq;
using Portfolio.Application.Interfaces;
using Portfolio.Application.Services;
using Portfolio.Domain.Entities;

namespace Portfolio.UnitTests.Services;

public class ProjectServiceTests
{
    private readonly Mock<IProjectRepository> _projectRepositoryMock;
    private readonly ProjectService _projectService;

    public ProjectServiceTests()
    {
        _projectRepositoryMock = new Mock<IProjectRepository>();
        _projectService = new ProjectService(_projectRepositoryMock.Object);
    }

    [Fact]
    public async Task GetAllAsync_Should_Return_Projects_Ordered_By_DisplayOrder()
    {
        // Arrange
        var projects = new List<Project>
        {
            new() { Id = 1, Title = "Project B", DisplayOrder = 2, Featured = false },
            new() { Id = 2, Title = "Project A", DisplayOrder = 1, Featured = true }
        };

        _projectRepositoryMock
            .Setup(repo => repo.GetAllAsync())
            .ReturnsAsync(projects);

        // Act
        var result = await _projectService.GetAllAsync();

        // Assert
        result.Should().HaveCount(2);
        result[0].Title.Should().Be("Project A");
        result[1].Title.Should().Be("Project B");
    }

    [Fact]
    public async Task GetFeaturedAsync_Should_Return_Only_Featured_Projects()
    {
        // Arrange
        var projects = new List<Project>
        {
            new() { Id = 1, Title = "Featured Project", Featured = true, DisplayOrder = 1 },
            new() { Id = 2, Title = "Regular Project", Featured = false, DisplayOrder = 2 }
        };

        _projectRepositoryMock
            .Setup(repo => repo.GetAllAsync())
            .ReturnsAsync(projects);

        // Act
        var result = await _projectService.GetFeaturedAsync();

        // Assert
        result.Should().HaveCount(1);
        result[0].Title.Should().Be("Featured Project");
        result[0].Featured.Should().BeTrue();
    }

    [Fact]
    public async Task GetAllAsync_Should_Return_Empty_List_When_No_Projects_Exist()
    {
        // Arrange
        _projectRepositoryMock
            .Setup(repo => repo.GetAllAsync())
            .ReturnsAsync(new List<Project>());

        // Act
        var result = await _projectService.GetAllAsync();

        // Assert
        result.Should().BeEmpty();
    }
}