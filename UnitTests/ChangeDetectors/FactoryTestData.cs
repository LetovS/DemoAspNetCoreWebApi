using AutoFixture;
using AutoFixture.AutoMoq;
using Store.Entities;

namespace UnitTests.ChangeDetectors;

/// <summary>
/// Фабрика для создание тестовых данных
/// </summary>
public static class FactoryTestData
{
    private static readonly IFixture Fixture = new Fixture().Customize(new AutoMoqCustomization());
    
    /// <summary>
    /// Создать нового провайдера
    /// </summary>
    public static ProviderRecord CreateNewProvider() => 
        Fixture
            .Build<ProviderRecord>()
            .With(x => x.ProviderName, Fixture.Create<string>())
            .Without(x => x.Orders)
            .Create();
    
    /// <summary>
    /// Создать новый заказ
    /// </summary>
    public static OrderRecord CreateNewOrder() => 
        Fixture
            .Build<OrderRecord>()
            .With(x => x.OrderNumber, Fixture.Create<string>())
            .With(x => x.ProviderId)
            .With(x => x.OrderDate)
            .With(x => x.Id)
            .Without(x => x.Provider)
            .Without(x => x.OrderItems)
            .Create();
    
    /// <summary>
    /// Создать новый товар
    /// </summary>
    public static OrderItemRecord CreateNewOrderItem() =>
        Fixture
            .Build<OrderItemRecord>()
            .With(x => x.Name, Fixture.Create<string>())
            .With(x => x.OrderId)
            .With(x => x.Quantity)
            .With(x => x.Unit)
            .Without(x => x.Order)
            .Create();
    
}