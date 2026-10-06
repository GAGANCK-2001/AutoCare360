using AutoCare360.Domain.Common;

namespace AutoCare360.Domain.Service;

public enum ServiceRequestStatus
{
    Draft = 0,
    InspectionPending = 1,
    EstimatePending = 2,
    ApprovalPending = 3,
    RepairInProgress = 4,
    Completed = 5,
    Cancelled = 6
}

public sealed class ServiceRequest : Entity
{
    private ServiceRequest() { }

    public ServiceRequest(Guid customerId, Guid vehicleId, string description)
    {
        if (customerId == Guid.Empty) throw new ArgumentException("Customer is required.", nameof(customerId));
        if (vehicleId == Guid.Empty) throw new ArgumentException("Vehicle is required.", nameof(vehicleId));
        if (string.IsNullOrWhiteSpace(description)) throw new ArgumentException("Description is required.", nameof(description));

        CustomerId = customerId;
        VehicleId = vehicleId;
        Description = description.Trim();
        Status = ServiceRequestStatus.Draft;
    }

    public Guid CustomerId { get; private set; }
    public Guid VehicleId { get; private set; }
    public string Description { get; private set; } = string.Empty;
    public ServiceRequestStatus Status { get; private set; }

    public void ChangeStatus(ServiceRequestStatus status)
    {
        if (status == ServiceRequestStatus.Draft && Status != ServiceRequestStatus.Draft)
            throw new InvalidOperationException("A service request cannot return to Draft.");

        Status = status;
        Touch();
    }
}
