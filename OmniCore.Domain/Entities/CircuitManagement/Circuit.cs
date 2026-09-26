using OmniCore.Domain.Entities.ClientManagement;
using OmniCore.Domain.Entities.Geography;
using OmniCore.Domain.Entities.InfrastructureManagement;

namespace OmniCore.Domain.Entities.CircuitManagement;
/// <summary>
/// Class representing a service to a customer
/// </summary>
public class Circuit
{
    public Guid Id { get; set; }
    public string? LinkID { get; set; }
    public string? ODUSerialNumber { get; set; }
    public string? IDUSerialNumber { get; set; }

    public Guid ClientId { get; set; }
    public Client? Client { get; set; }
    public string? CircuitName { get; set; }
    public string? ServiceAddress { get; set; }
    public string? Town { get; set; }

    public int StateId { get; set; }
    public State? State { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public string? Coordinates { get; private set; }
    public Service? Service { get; set; }
    public double? AnnualRevenue { get; set; }
    public double? Bandwidth { get; set; }
    public Guid? CircuitStateId { get; set; }
    public CircuitState? CircuitState { get; set; }
    public Guid? IPPoPId { get; set; }
    public IPPoP? IPPoP { get; set; }
    public string? AccountManager { get; set; }
    public string? ProjectManager { get; set; }
    public DateOnly? ServiceStartDate { get; set; }
    public string? ClientContactDetails { get; set; }
    public string? InstallersContactDetails { get; set; }
    public string? LastMileName { get; set; }
    public Guid? LastMileDeviceId { get; set; }
    public LastMileDevice? LastMileDevice { get; set; }
    public string? TransmissionPath { get; set; }
    public double? PathLength { get; set; }
    public int? RadioManagementVLAN { get; set; }
    public int? ServiceVLAN { get; set; }
    public int? RadioFrequency { get; set; }
    public string? ManagedRadioIPAtPoP { get; set; }
    public string? ManagedRadioIPAtClient { get; set; }
    public string? ManagedRadioIPGateway { get; set; }
    public string? AssignedPublicIP { get; set; }
    public string? AssignedGateway { get; set; }
    public string? AssignedSubnetMask { get; set; }
}
