namespace OmniCore.Domain.Entities.InfrastructureManagement;

/// <summary>
/// The transmission device for service delivery from the ip pop to customer location
/// </summary>

public class LastMileDevice
{
    public Guid Id { get; set; }
    public string? LastMileDeviceName { get; set; }
}

