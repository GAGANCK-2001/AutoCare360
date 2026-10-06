using AutoCare360.Domain.Service;

namespace AutoCare360.Domain.Tests;

public sealed class ServiceRequestTests
{
    [Fact]
    public void NewRequest_ShouldStartInDraft()
    {
        var request = new ServiceRequest(
            Guid.NewGuid(),
            Guid.NewGuid(),
            "Brake inspection");

        Assert.Equal(ServiceRequestStatus.Draft, request.Status);
    }

    [Fact]
    public void StatusChange_ShouldUpdateStatus()
    {
        var request = new ServiceRequest(
            Guid.NewGuid(),
            Guid.NewGuid(),
            "Brake inspection");

        request.ChangeStatus(ServiceRequestStatus.InspectionPending);

        Assert.Equal(ServiceRequestStatus.InspectionPending, request.Status);
    }
}
