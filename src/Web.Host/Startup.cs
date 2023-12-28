using Business.Automapper;
using Business.DI;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Repositories.DI;
using Store.ConfigurationOptions;
using Store.DI;
using System.Reflection;
using Web.Api.Controllers;

namespace Web.Hosts;

/// <summary>
/// Конфигурация хоста <see cref="Program"/>
/// </summary>
public sealed class Startup
{
    private readonly IConfiguration configuration;

    public Startup(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    /// <summary>
    /// Конфигуратор сервисов
    /// </summary>
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers().AddApplicationPart(typeof(TestController).Assembly);
        services.AddEndpointsApiExplorer();

        services.AddSwaggerGen(c =>
        {
            c.UseAllOfToExtendReferenceSchemas();

            var xmlFile = $"{typeof(TestController).Assembly.GetName().Name}.xml";

            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            c.IncludeXmlComments(xmlPath);
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Platform Resources API"
            });

            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
        });


        var databaseOptions = new DatabaseOptions();
        
        configuration.GetSection(nameof(DatabaseOptions)).Bind(databaseOptions);
        
        services.AddStoreDependencies(databaseOptions);

        services.AddRepositoriesAndEntityFactory();

        services.AddCors();

        services.AddAutoMapper(profile =>
        {
            profile.AddProfile<BusinessProfile>();
        });

        services.AddBusinessServices();        
    }

    public void Configure(
        IApplicationBuilder builder)
    {

        builder.UseSwagger();

        builder.UseSwaggerUI(opt =>
        {
            opt.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");

        });

        builder.UseHttpsRedirection();

        builder.UseRouting();

        builder.UseCors();

        builder.UseEndpoints(options => options.MapControllers());
    }
}
