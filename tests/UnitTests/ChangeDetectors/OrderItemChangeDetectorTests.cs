using AutoFixture;
using Business.Abstract.Services;
using Business.Implementations.HasNoChange;
using Business.Models.OrderItem;
using FluentAssertions;
using Moq;
using Xunit;

namespace UnitTests.ChangeDetectors;

/// <summary>
/// Тест детектора изменений товаров
/// </summary>
public class OrderItemChangeDetectorTests : ChangeDetectorBase
{
    private readonly OrderItemChangeDetector _sut;
    private readonly Mock<IOrderItemService> _providerReadRepositoryMock;

    /// <summary>
    /// ctor.
    /// </summary>
    public OrderItemChangeDetectorTests()
    {
        _providerReadRepositoryMock = Fixture.Freeze<Mock<IOrderItemService>>();
        _sut = Fixture.Create<OrderItemChangeDetector>();
    }

    [Fact(DisplayName = "Проверка эквивалентности сущности и модели. Сущность и модель эквивалентны.")]
    internal void HasNoChanges_NoChanges_ShouldBeTrue()
    {
        // Arrange
        var entity = FactoryTestData.CreateNewOrderItem();

        var model = new UpdateOrderItemModel(entity.Name!, entity.Quantity, entity.Unit!, entity.OrderId);

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
        var entity = FactoryTestData.CreateNewOrderItem();

        var model = new UpdateOrderItemModel(Fixture.Create<string>(),
            Fixture.Create<decimal>(),
            Fixture.Create<string>(),
            Fixture.Create<Guid>());

        _providerReadRepositoryMock.Setup(x => x.GetByIdAsync(entity.Id, It.IsAny<CancellationToken>()))
            .ReturnsAsync(entity);

        // Act
        var result = _sut.HasNoChanges(entity, model);

        // Assert
        result.Should().BeFalse();
    }
}