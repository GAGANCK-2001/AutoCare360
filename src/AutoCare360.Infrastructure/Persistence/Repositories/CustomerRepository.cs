using AutoCare360.Application.Customers;
using AutoCare360.Domain.Customers;
using Microsoft.EntityFrameworkCore;

namespace AutoCare360.Infrastructure.Persistence.Repositories;

public sealed class CustomerRepository : ICustomerRepository
{
    private readonly AutoCare360DbContext _dbContext;

    public CustomerRepository(AutoCare360DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAsync(
        Customer customer,
        CancellationToken cancellationToken = default)
    {
        await _dbContext.Customers.AddAsync(customer, cancellationToken);
    }

    public Task<Customer?> GetByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        return _dbContext.Customers
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == id, cancellationToken);
    }
}
