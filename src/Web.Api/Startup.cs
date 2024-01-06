//using Business.Automapper;
//using Business.DI;
//using Microsoft.OpenApi.Models;
//using Repositories.DI;
//using Store.ConfigurationOptions;
//using Store.DI;

//namespace Web.Hosts;

///// <summary>
///// Конфигурация хоста <see cref="Program"/>
///// </summary>
//public sealed class Startup
//{
//    private readonly IConfiguration configuration;

//    /// <summary>
//    /// ctor.
//    /// </summary>
//    public Startup(IConfiguration configuration)
//    {
//        this.configuration = configuration;
//    }

//    /// <summary>
//    /// Конфигуратор сервисов
//    /// </summary>
//    public void ConfigureServices(IServiceCollection services)
//    {
//        services.AddControllers().AddApplicationPart(typeof(ProviderController).Assembly);
//        services.AddEndpointsApiExplorer();

//        services.AddSwaggerGen(c =>
//        {
//            var xmlFile = $"{typeof(ProviderController).Assembly.GetName().Name}.xml";
//            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

//            c.IncludeXmlComments(xmlPath);

//            c.SwaggerDoc("v1", new OpenApiInfo
//            {
//                Title = "Platform Resources API",
//                Version = "v1"
//            });
//        });

//        services
//            .AddFluentValidationAutoValidation(cfg =>
//            {
//                cfg.DisableDataAnnotationsValidation = false;
//            });
//        services.AddValidatorsFromAssemblyContaining<CreateProviderRequestValidator>();

//        var databaseOptions = new DatabaseOptions();

//        configuration.GetSection(nameof(DatabaseOptions)).Bind(databaseOptions);

//        services.AddStoreDependencies(databaseOptions);

//        services.AddRepositoriesAndEntityFactory();

//        services.AddCors();

//        services.AddAutoMapper(profile =>
//        {
//            profile.AddProfile<BusinessProfile>();
//        });

//        services.AddBusinessServices();

//        services.AddWebApiServices();
//    }

//    /// <summary>
//    /// Конфигурация middleware
//    /// </summary>
//#pragma warning disable CA1822 // Mark members as static
//    public void Configure(IApplicationBuilder builder)
//#pragma warning restore CA1822 // Mark members as static
//    {
//        builder.UseSwagger();

//        builder.UseSwaggerUI(opt =>
//        {
//            opt.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
//            opt.RoutePrefix = string.Empty;

//        });

//        builder.UseHttpsRedirection();

//        builder.UseRouting();

//        builder.UseCors();

//        builder.UseEndpoints(options => options.MapControllers());
//    }
//}
