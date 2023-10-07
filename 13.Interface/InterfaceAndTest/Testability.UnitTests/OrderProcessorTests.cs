using Testability.Models;

namespace Testability.UnitTests;

public class OrderProcessorTests
{
    // MethodName_Condition_Expectation
    [Fact]
    public void Process_OrderIsAlreadyShipped_ThrowsAnException()
    {
        // Arrange
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        var order = new Order
        {
            Shipment = new Shipment()
        };

        // Act
        Action act = () => orderProcessor.Process(order);

        // Assert
        Assert.Throws<InvalidOperationException>(act);
        Assert.Throws<InvalidOperationException>(() => orderProcessor.Process(order));
    }


    // MethodName_Condition_Expectation
    [Fact]
    public void Process_OrderIsNotShipped_SetTheShipmentPropertyOfTheOrder()
    {
        // Arrange
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        var order = new Order();

        //Act
        orderProcessor.Process(order);

        //Assert
        Assert.True(order.IsShipped);
        Assert.Equal(1, order.Shipment.Cost);
        Assert.Equal(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
    }
}

public class FakeShippingCalculator : IShippingCalculator
{
    public float CalculateShipping(Order order)
    {
        return 1;
    }
}