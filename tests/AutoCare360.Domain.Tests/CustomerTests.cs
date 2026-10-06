using Xunit;
using AutoCare360.Domain.Customers;

namespace AutoCare360.Domain.Tests;

public sealed class CustomerTests
{
    [Fact]
    public void Constructor_ShouldCreateValidCustomer()
    {
        var customer = new Customer("Gagan", "K", "gagan@example.com", "9999999999");

        Assert.NotEqual(Guid.Empty, customer.Id);
        Assert.Equal("Gagan", customer.FirstName);
        Assert.Equal("K", customer.LastName);
    }

    [Fact]
    public void Constructor_ShouldRejectMissingEmail()
    {
        Assert.Throws<ArgumentException>(() =>
            new Customer("Gagan", "K", "", "9999999999"));
    }
}
