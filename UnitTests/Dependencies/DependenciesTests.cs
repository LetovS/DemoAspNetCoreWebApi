using Xunit;

namespace UnitTests.Dependencies;

public class DependenciesTests : IClassFixture<ContainerFixture>
{
    private readonly IServiceProvider container;

    /// <summary>
    /// .ctor
    /// </summary>
    public DependenciesTests(ContainerFixture fixture)
    {
        container = fixture.Container;
    }

    [Fact]
    public void Test()
    {
        Assert.True(true);
    }
}