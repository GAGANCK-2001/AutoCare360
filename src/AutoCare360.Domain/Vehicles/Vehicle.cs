using AutoCare360.Domain.Common;

namespace AutoCare360.Domain.Vehicles;

public sealed class Vehicle : Entity
{
    private Vehicle() { }

    public Vehicle(Guid customerId, string registrationNumber, string make, string model, int year)
    {
        if (customerId == Guid.Empty) throw new ArgumentException("Customer is required.", nameof(customerId));
        if (string.IsNullOrWhiteSpace(registrationNumber)) throw new ArgumentException("Registration number is required.", nameof(registrationNumber));
        if (string.IsNullOrWhiteSpace(make)) throw new ArgumentException("Make is required.", nameof(make));
        if (string.IsNullOrWhiteSpace(model)) throw new ArgumentException("Model is required.", nameof(model));
        if (year < 1900 || year > DateTime.UtcNow.Year + 1) throw new ArgumentOutOfRangeException(nameof(year));

        CustomerId = customerId;
        RegistrationNumber = registrationNumber.Trim().ToUpperInvariant();
        Make = make.Trim();
        Model = model.Trim();
        Year = year;
    }

    public Guid CustomerId { get; private set; }
    public string RegistrationNumber { get; private set; } = string.Empty;
    public string Make { get; private set; } = string.Empty;
    public string Model { get; private set; } = string.Empty;
    public int Year { get; private set; }
}
