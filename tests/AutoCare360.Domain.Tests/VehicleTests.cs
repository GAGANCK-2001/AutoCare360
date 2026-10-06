using AutoCare360.Domain.Vehicles;

namespace AutoCare360.Domain.Tests;

public sealed class VehicleTests
{
    [Fact]
    public void Constructor_ShouldNormalizeRegistrationNumber()
    {
        var customerId = Guid.NewGuid();

        var vehicle = new Vehicle(
            customerId,
            "ka01ab1234",
            "Toyota",
            "Corolla",
            2022);

        Assert.Equal("KA01AB1234", vehicle.RegistrationNumber);
        Assert.Equal(customerId, vehicle.CustomerId);
    }

    [Fact]
    public void Constructor_ShouldRejectInvalidYear()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
            new Vehicle(Guid.NewGuid(), "KA01AB1234", "Toyota", "Corolla", 1800));
    }
}
