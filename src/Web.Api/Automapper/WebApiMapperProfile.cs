using AutoMapper;
using Business.Models.Provider;
using Store.Entities;
using Web.Api.Automapper.Converters;
using Web.Contracts.Models.Order;
using Web.Contracts.Models.Provider;

namespace Web.Api.Automapper;

/// <summary>
/// Профайл маппа Request models to Business models
/// </summary>
public class WebApiMapperProfile : Profile
{
    /// <summary>
    /// ctor.
    /// </summary>
    public WebApiMapperProfile()
    {
        CreateMap<CreateProviderRequest, CreateProviderModel>()            
            .ForCtorParam("providerName", x => x.MapFrom(y => y.Name));

        CreateMap<UpdateProviderRequest, UpdateProviderModel>()
            .ForCtorParam("providerName", x => x.MapFrom(y => y.Name));
    }   
}

