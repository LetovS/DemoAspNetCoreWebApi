using AutoMapper;
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
        CreateMap<List<ProviderRecord>, IEnumerable<ProviderResponse>>()
            .ConvertUsing<ProviderConverter>();
        
        // Предполагается, что у вас есть маппинг для OrderRecord и OrderResponse
        CreateMap<OrderRecord, OrderResponse>();
    }   
}

