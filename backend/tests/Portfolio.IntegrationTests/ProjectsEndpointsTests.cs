using System.Net;
using System.Net.Http.Json;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Portfolio.Application.DTOs;

namespace Portfolio.IntegrationTests;

public class ProjectsEndpointsTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public ProjectsEndpointsTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task Get_Projects_Should_Return_Ok_And_Projects()
    {
        // Act
        var response = await _client.GetAsync("/api/projects");

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var projects = await response.Content.ReadFromJsonAsync<List<ProjectDto>>();
        projects.Should().NotBeNull();
        projects.Should().NotBeEmpty();
    }

    [Fact]
    public async Task Get_Featured_Projects_Should_Return_Only_Featured_Projects()
    {
        // Act
        var response = await _client.GetAsync("/api/projects/featured");

        // Assert
        response.StatusCode.Should().Be(HttpStatusCode.OK);

        var projects = await response.Content.ReadFromJsonAsync<List<ProjectDto>>();
        projects.Should().NotBeNull();
        projects.Should().NotBeEmpty();
        projects!.Should().OnlyContain(project => project.Featured);
    }
}