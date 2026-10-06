using AutoCare360.Application.Customers;
using Microsoft.AspNetCore.Mvc;

namespace AutoCare360.Api.Controllers;

[ApiController]
[Route("api/v1/customers")]
public sealed class CustomersController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomersController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpPost]
    [ProducesResponseType(typeof(CustomerDto), StatusCodes.Status201Created)]
    public async Task<IActionResult> Create(
        CreateCustomerRequest request,
        CancellationToken cancellationToken)
    {
        var customer = await _customerService.CreateAsync(
            request.FirstName,
            request.LastName,
            request.Email,
            request.PhoneNumber,
            cancellationToken);

        return CreatedAtAction(nameof(GetById), new { id = customer.Id }, customer);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
        => Ok(new { id, message = "Customer lookup placeholder for Phase 1." });
}

public sealed record CreateCustomerRequest(
    string FirstName,
    string LastName,
    string Email,
    string PhoneNumber);
