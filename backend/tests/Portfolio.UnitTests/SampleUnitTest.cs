using FluentAssertions;

namespace Portfolio.UnitTests;

public class SampleUnitTest
{
    [Fact]
    public void True_Should_Be_True()
    {
        // Arrange
        var value = true;

        // Act / Assert
        value.Should().BeTrue();
    }
}