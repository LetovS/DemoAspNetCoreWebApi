using Microsoft.Extensions.DependencyInjection;
using Web.Api.Automapper;

namespace Web.Api.DI;

/// <summary>
/// Расширение для <see cref="IServiceCollection"/>
/// </summary>
public static class WebApiServiceCollectionExtension
{
    /// <summary>
    /// Добавление сервисов Web.Api
    /// </summary>
    public static void AddWebApiServices(this IServiceCollection services)
    {
        services.AddAutoMapper(x => x.AddProfile<WebApiMapperProfile>());
    }

}
