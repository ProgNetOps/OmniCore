
namespace OmniCore.Domain.Entities.ClientManagement;
/// <summary>
/// Class representing a service to a customer
/// </summary>
public class Link:AuditableEntity
{
    public Guid LinkId { get; set; }
    public Guid ClientId { get; set; }
    public Client? Client { get; set; }
    public string? LinkName { get; set; }
    public Address? LocationOfCustomer { get; set; }    
    public string? ClientContactDetails { get; set; }
    public Service? Service { get; set; }
    public double? AnnualRevenue { get; set; }
    public double? Bandwidth { get; set; }
    public LinkState CircuitState { get; set; }
    public Guid? IPPoPId { get; set; }
    public IPPoP? IPPoP { get; set; }
    public string? AccountManager { get; set; }
    public string? ProjectManager { get; set; }
    public DateOnly? ServiceStartDate { get; set; }
    public string? InstallersContactDetails { get; set; }
    public string? LastMileName { get; set; }
    public Guid? LastMileDeviceId { get; set; }
    public LastMileDevice? LastMileDevice { get; set; }
    public string? ODUSerialNumber { get; set; }
    public string? IDUSerialNumber { get; set; }
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
