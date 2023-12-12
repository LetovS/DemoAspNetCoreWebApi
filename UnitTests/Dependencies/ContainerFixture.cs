using Microsoft.Extensions.Hosting;
using Web.Hosts;

namespace UnitTests.Dependencies;

/// <summary>
/// Fixture контейнера Api
/// </summary>
public sealed class ContainerFixture : IDisposable
{
    private readonly IHost host;

    /// <summary>
    /// .ctor
    /// </summary>
    public ContainerFixture()
    {
        host = Program.CreateHostBuilder(Array.Empty<string>()).Build();
    }

    public IServiceProvider Container => host.Services;

    /// <inheritdoc />
    public void Dispose()
    {
        host.Dispose();
    }
}