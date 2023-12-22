using AutoMapper;
using Business.Models.Order;
using Business.Models.OrderItem;
using Business.Models.Provider;
using Store.Entities;

namespace Business.Automapper;

/// <summary>
/// Бизнес профайл
/// </summary>
public class BusinessProfile : Profile
{
    /// <summary>
    /// ctor.
    /// </summary>
    public BusinessProfile()
    {
        CreateMap<CreateProviderModel, ProviderRecord>()
            .DisableCtorValidation()
            .ValidateMemberList(MemberList.Source)
            .ForMember(x => x.ProviderName, opt => opt.MapFrom(y => y.ProviderName));

        CreateMap<UpdateProviderModel, ProviderRecord>()
            .DisableCtorValidation()
            .ValidateMemberList(MemberList.Source)
            .ForMember(x => x.ProviderName, opt => opt.MapFrom(y => y.ProviderName));

        CreateMap<CreateOrderModel, OrderRecord>()
            .DisableCtorValidation()
            .ValidateMemberList(MemberList.Source)
            .ForMember(x => x.OrderNumber, opt => opt.MapFrom(y => y.OrderNumber))
            .ForMember(x => x.OrderDate, opt => opt.MapFrom(y => y.OrderDate))
            .ForMember(x => x.ProviderId, opt => opt.MapFrom(y => y.ProviderId));

        CreateMap<UpdateOrderModel, OrderRecord>()
            .DisableCtorValidation()
            .ValidateMemberList(MemberList.Source)
            .ForMember(x => x.OrderNumber, opt => opt.MapFrom(y => y.OrderNumber))
            .ForMember(x => x.OrderDate, opt => opt.MapFrom(y => y.OrderDate))
            .ForMember(x => x.ProviderId, opt => opt.MapFrom(y => y.ProviderId));


        CreateMap<CreateOrderItemModel, OrderItemRecord>()
            .DisableCtorValidation()
            .ValidateMemberList(MemberList.Source)
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name))
            .ForMember(x => x.Quantity, opt => opt.MapFrom(y => y.Quantity))
            .ForMember(x => x.Unit, opt => opt.MapFrom(y => y.Unit))
            .ForMember(x => x.OrderId, opt => opt.MapFrom(y => y.OrderId));

        CreateMap<UpdateOrderItemModel, OrderItemRecord>()
            .DisableCtorValidation()
            .ValidateMemberList(MemberList.Source)
            .ForMember(x => x.Name, opt => opt.MapFrom(y => y.Name))
            .ForMember(x => x.Quantity, opt => opt.MapFrom(y => y.Quantity))
            .ForMember(x => x.Unit, opt => opt.MapFrom(y => y.Unit))
            .ForMember(x => x.OrderId, opt => opt.MapFrom(y => y.OrderId));
    }
}