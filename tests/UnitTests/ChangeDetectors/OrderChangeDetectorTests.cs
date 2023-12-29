using AutoFixture;
using Business.Abstract.Services;
using Business.Implementations.HasNoChange;
using Business.Models.Order;
using FluentAssertions;
using Moq;
using Xunit;

namespace UnitTests.ChangeDetectors;

/// <summary>
/// Тест детектора изменений заказов
/// </summary>
public sealed class OrderChangeDetectorTests : ChangeDetectorBase
{
    private readonly OrderChangeDetector _sut;
    private readonly Mock<IOrderService> _providerReadRepositoryMock;

    /// <summary>
    /// ctor.
    /// </summary>
    public OrderChangeDetectorTests()
    {
        _providerReadRepositoryMock = Fixture.Freeze<Mock<IOrderService>>();
        _sut = Fixture.Create<OrderChangeDetector>();
    }

    [Fact(DisplayName = "Проверка эквивалентности сущности и модели. Сущность и модель эквивалентны.")]
    internal void HasNoChanges_NoChanges_ShouldBeTrue()
    {
        // Arrange
        var entity = FactoryTestData.CreateNewOrder();

        var model = new UpdateOrderModel(entity.OrderNumber!, entity.OrderDate, entity.ProviderId);

        _providerReadRepositoryMock.Setup(x => x.GetByIdAsync(entity.Id, It.IsAny<CancellationToken>()))
            .ReturnsAsync(entity);

        // Act
        var result = _sut.HasNoChanges(entity, model);

        // Assert
        result.Should().BeTrue();
    }

    [Fact(DisplayName = "Проверка эквивалентности сущности и модели. Сущность и модель неэквивалентны.")]
    internal void HasNoChanges_WithChanges_ShouldBeFalse()
    {
        // Arrange
        var entity = FactoryTestData.CreateNewOrder();

        var model = new UpdateOrderModel(Fixture.Create<string>(), entity.OrderDate, Fixture.Create<Guid>());

        _providerReadRepositoryMock.Setup(x => x.GetByIdAsync(entity.Id, It.IsAny<CancellationToken>()))
            .ReturnsAsync(entity);

        // Act
        var result = _sut.HasNoChanges(entity, model);

        // Assert
        result.Should().BeFalse();
    }
}