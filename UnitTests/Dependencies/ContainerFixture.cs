using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Program = Web.Host.Program;

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
        host = Program.CreateHostBuilder(Array.Empty<string>(), b =>
            {
                var builder = Program.ConfigureWebHostBuilder(b);
            })
            .Build();
    }

    public IServiceProvider Container => host.Services;

    /// <inheritdoc />
    public void Dispose()
    {
        host.Dispose();
    }
}