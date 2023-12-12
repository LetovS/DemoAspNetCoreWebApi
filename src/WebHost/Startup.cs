using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories.DI;
using Store.ConfigurationOptions;
using Store.DI;

namespace Web.Host;

public sealed class Startup
{
    private readonly IConfiguration configuration;

    public Startup(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        var databaseOptions = new DatabaseOptions();
        
        configuration.GetSection(nameof(DatabaseOptions)).Bind(databaseOptions);
        
        services.AddStoreDependencies(databaseOptions);

        services.AddRepositoriesAndEntityFactory();
    }

    public void Configure(IApplicationBuilder app)
    {
        
    }
}

