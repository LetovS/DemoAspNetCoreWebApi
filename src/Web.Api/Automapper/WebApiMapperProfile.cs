using AutoMapper;
using Business.Models.Order;
using Business.Models.OrderItem;
using Business.Models.Provider;
using Microsoft.Data.SqlClient;
using Store.Entities;
using Web.Api.Automapper.Converters;
using Web.Contracts.Models.Order;
using Web.Contracts.Models.OrderItem;
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
        #region Маппинг провайдера
        CreateMap<CreateProviderRequest, CreateProviderModel>()            
            .ForCtorParam("providerName", x => x.MapFrom(y => y.Name));

        CreateMap<UpdateProviderRequest, UpdateProviderModel>()
            .ForCtorParam("providerName", x => x.MapFrom(y => y.Name));

        CreateMap<ProviderRecord, ProviderResponse>()
            .ForCtorParam("id", opt => opt.MapFrom(y => y.Id))
            .ForCtorParam("name", opt => opt.MapFrom(y => y.ProviderName))
            .ForMember(x => x.Orders, opt => opt.Ignore());

        #endregion

        #region Маппинг заказа
        CreateMap<CreateOrderRequest, CreateOrderModel>()
            .ForCtorParam("orderNumber", opt => opt.MapFrom(x => x.OrderNumber))
            .ForCtorParam("orderDate", opt => opt.MapFrom(y => y.OrderDate))
            .ForCtorParam("providerId", opt => opt.MapFrom(y => y.ProviderId));
        
        CreateMap<UpdateOrderRequest, UpdateOrderModel>()
            .ForCtorParam("orderNumber", opt => opt.MapFrom(x => x.OrderNumber))
            .ForCtorParam("orderDate", opt => opt.MapFrom(y => y.OrderDate))
            .ForCtorParam("providerId", opt => opt.MapFrom(y => y.ProviderId));

        CreateMap<OrderRecord, OrderResponse>()
            .ForCtorParam("id", opt => opt.MapFrom(y => y.Id))
            .ForCtorParam("orderNumber", opt => opt.MapFrom(x => x.OrderNumber))
            .ForCtorParam("orderDate", opt => opt.MapFrom(y => y.OrderDate))
            .ForCtorParam("providerId", opt => opt.MapFrom(y => y.ProviderId))
            .ForMember(x => x.OrderItems, opt => opt.Ignore());
        #endregion

        #region Маппинг элементов

        CreateMap<CreateOrderItemRequest, CreateOrderItemModel>();

        CreateMap<UpdateOrderItemRequest, UpdateOrderItemModel>();
        
        CreateMap<OrderItemRecord, OrderItemResponse>();
        
        #endregion
    }   
}

