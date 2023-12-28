using Microsoft.Extensions.Hosting;
using Store.Migrations;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTests")]
namespace Web.Hosts;

internal static class Program
{
    internal static void Main(string[] args)
    {
        DatabaseMigrationManager.MigrateSchema().ConfigureAwait(false);
        CreateHostBuilder(args).Build().Run();
    }
    internal static IHostBuilder CreateHostBuilder(string[] args) =>
                                    Host.CreateDefaultBuilder(args).ConfigureServices((x,y) =>
                                    {
                                        var config = x.Configuration;
                                        y.ConfigureServices(config);
                                    });
}