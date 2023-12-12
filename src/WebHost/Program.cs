using Store.DI;
using Microsoft.Extensions.Hosting;
using Hosts;
using Microsoft.Extensions.Configuration;
using Repositories.DI;
using Store.ConfigurationOptions;


Host
    .CreateDefaultBuilder(args)
    .ConfigureServices((hostBuilder, services) =>
    {
        var databaseOptions = new DatabaseOptions();

        hostBuilder.Configuration.GetSection(nameof(DatabaseOptions)).Bind(databaseOptions);

        services.AddStoreDependencies(databaseOptions);

        services.AddRepositoriesAndEntityFactory();
    })
    .Build()
    .MigrateDatabase()
    .Run();
