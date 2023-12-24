using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Store.Migrations;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTests")]
namespace Web.Hosts;

internal static class Program
{
    internal static async Task Main(string[] args)
    {
        DatabaseMigrationManager.MigrateSchema().ConfigureAwait(false);
        //CreateHostBuilder(args).Build().Run();


        await CreateHostBuilder(args, b => ConfigureWebHostBuilder(b))
            .Build()
            .RunAsync();
    }
    //internal static IHostBuilder CreateHostBuilder(string[] args) =>
    //                                Host.CreateDefaultBuilder(args).ConfigureServices((x,y) =>
    //                                {
    //                                    var config = x.Configuration;
    //                                    y.ConfigureServices(config);
    //                                });

    /// <summary>
    ///  Создает построитель хоста
    /// </summary>
    public static IHostBuilder CreateHostBuilder(string[] args, Action<IWebHostBuilder> webHostBuilderConfigurator)
        => Host
            .CreateDefaultBuilder()
            .ConfigureWebHostDefaults(webHostBuilderConfigurator);

    /// <summary>
    /// Создает построитель веб хост
    /// </summary>
    public static IWebHostBuilder ConfigureWebHostBuilder(IWebHostBuilder webHostBuilder)
        => webHostBuilder
            .UseStartup<Startup>();
}