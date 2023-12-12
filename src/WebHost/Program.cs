using CustomHost = Microsoft.Extensions.Hosting;
using Store.DI;
using Microsoft.Extensions.Hosting;
using Host;
using Microsoft.Extensions.Configuration;
using Repositories.DI;
using Store.ConfigurationOptions;
using Store.Migrations;


CustomHost.Host
    .CreateDefaultBuilder(args)
    .ConfigureServices((hostBuilder, services) =>
    {
        var ttt = typeof(ResourcesContextFactory).Assembly.FullName;

        var databaseOptions = new DatabaseOptions();
        hostBuilder.Configuration.GetSection(nameof(DatabaseOptions)).Bind(databaseOptions);
        services.AddStoreDependencies(databaseOptions);
        services.AddRepositoriesAndEntityFactory();
    })
    .Build()
    .MigrateDatabase()
    .Run();
