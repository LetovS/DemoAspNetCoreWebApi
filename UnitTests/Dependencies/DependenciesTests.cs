using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Abstract;
using Repositories.Implementations.Order;
using Repositories.Implementations.Provider;
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

    [Theory]
    [MemberData(nameof(Repositories))]
    internal void ControllerShouldBeResolved(Type repository)
    {
        var constructorsParams = repository.GetConstructors()[0].GetParameters();

        var services = constructorsParams
            .Select(x => container.GetRequiredService(x.ParameterType))
            .ToList();

        services.Should().NotBeNull().And.HaveCount(constructorsParams.Length);
    }

    /// <summary>
    /// Список контроллеров Api
    /// </summary>
    public static IEnumerable<object[]> Repositories()
    {
        var implements = typeof(ProviderReadRepository).Assembly
            .DefinedTypes
            .Where(type => typeof(IDbRepository).IsAssignableFrom(type))
            .Where(type => !type.IsAbstract).Select(type => new[] { type });
        return implements;
    }
}