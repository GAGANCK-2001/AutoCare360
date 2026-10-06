using AutoCare360.Domain.Customers;

namespace AutoCare360.Application.Customers;

public sealed class CustomerService : ICustomerService
{
    public Task<CustomerDto> CreateAsync(
        string firstName,
        string lastName,
        string email,
        string phoneNumber,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var customer = new Customer(firstName, lastName, email, phoneNumber);

        var dto = new CustomerDto(
            customer.Id,
            customer.FirstName,
            customer.LastName,
            customer.Email,
            customer.PhoneNumber);

        return Task.FromResult(dto);
    }
}
