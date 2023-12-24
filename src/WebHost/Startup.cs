using Business.DI;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Repositories.DI;
using Store.ConfigurationOptions;
using Store.DI;
using System.Reflection;

namespace Web.Hosts;

/// <summary>
/// Конфигурация хоста <see cref="Program"/>
/// </summary>
public class Startup
{
    private readonly IConfiguration configuration;

    /// <summary>
    /// ctor.
    /// </summary>
    public Startup(IConfiguration configuration)
    {
        this.configuration = configuration;
    }
    /// <summary>
    /// Конфигуратор сервисов
    /// </summary>
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();

        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Web API",
                Version = "v1"
            });
            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
        });

        var databaseOptions = new DatabaseOptions();
        
        configuration.GetSection(nameof(DatabaseOptions)).Bind(databaseOptions);
        
        services.AddStoreDependencies(databaseOptions);

        services.AddRepositoriesAndEntityFactory();

        services.AddBusinessServices();        
    }

    /// <summary>
    /// Настройка ПО промежуточного слоя
    /// </summary>
    /// <param name="app"></param>
    /// <param name="env"></param>
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (!env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseDeveloperExceptionPage();
        }

        //app.UseAuthorization();

        //app.MapControllers();

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        //app.UseCookiePolicy();

        //app.UseAuthentication();
                
        app.UseRouting();

        app.UseEndpoints(options => options.MapControllers());
    }
}

