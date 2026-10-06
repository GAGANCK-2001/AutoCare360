namespace AutoCare360.Application.Customers;

public interface ICustomerService
{
    Task<CustomerDto> CreateAsync(
        string firstName,
        string lastName,
        string email,
        string phoneNumber,
        CancellationToken cancellationToken = default);
}
