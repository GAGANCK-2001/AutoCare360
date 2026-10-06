using AutoCare360.Domain.Common;

namespace AutoCare360.Domain.Claims;

public enum ClaimStatus
{
    Submitted = 0,
    UnderReview = 1,
    Approved = 2,
    Rejected = 3,
    Closed = 4
}

public sealed class Claim : Entity
{
    private Claim() { }

    public Claim(Guid customerId, Guid vehicleId, decimal claimedAmount)
    {
        if (customerId == Guid.Empty) throw new ArgumentException("Customer is required.", nameof(customerId));
        if (vehicleId == Guid.Empty) throw new ArgumentException("Vehicle is required.", nameof(vehicleId));
        if (claimedAmount <= 0) throw new ArgumentOutOfRangeException(nameof(claimedAmount));

        CustomerId = customerId;
        VehicleId = vehicleId;
        ClaimedAmount = claimedAmount;
        Status = ClaimStatus.Submitted;
    }

    public Guid CustomerId { get; private set; }
    public Guid VehicleId { get; private set; }
    public decimal ClaimedAmount { get; private set; }
    public ClaimStatus Status { get; private set; }
}
