using Business.Automapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.OpenApi.Models;
using Store.ConfigurationOptions;
using Web.Api.Controllers;
using Web.Api.DI;
using Web.Api.Validators.Provider;
using Store.DI;
using Repositories.DI;
using Business.DI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSwaggerGen(c =>
{
    var xmlFile = $"{typeof(ProviderController).Assembly.GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

    c.IncludeXmlComments(xmlPath);

    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Platform Resources API",
        Version = "v1"
    });
});

builder.Services.AddFluentValidationAutoValidation(cfg =>
    {
        cfg.DisableDataAnnotationsValidation = false;
    });

builder.Services.AddValidatorsFromAssemblyContaining<CreateProviderRequestValidator>();

var databaseOptions = new DatabaseOptions();

var configuration = builder.Configuration;

configuration.GetSection(nameof(DatabaseOptions)).Bind(databaseOptions);

builder.Services.AddStoreDependencies(databaseOptions);

builder.Services.AddRepositoriesAndEntityFactory();

builder.Services.AddCors();

builder.Services.AddAutoMapper(profile =>
{
    profile.AddProfile<BusinessProfile>();
});

builder.Services.AddBusinessServices();

builder.Services.AddWebApiServices();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
