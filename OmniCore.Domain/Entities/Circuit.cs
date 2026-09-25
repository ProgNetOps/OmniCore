using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OmniCore.Domain.Entities;
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
    public Client Client { get; set; }
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
    [ForeignKey(nameof(CircuitStateId))]
    public CircuitState? CircuitState { get; set; }

    public Guid? IPPoPId { get; set; }
    [ForeignKey(nameof(IPPoPId))]
    public IPPoP? IPPoP { get; set; }

    [StringLength(100)]
    public string? AccountManager { get; set; }

    [StringLength(100)]
    public string? ProjectManager { get; set; }

    [DataType(DataType.Date)]
    public DateOnly? ServiceStartDate { get; set; }

    [StringLength(1000)]
    public string? ClientContactDetails { get; set; }

    [StringLength(1000)]
    public string? InstallersContactDetails { get; set; }

    //Technical Details
    public string? LastMileName { get; set; }
    public Guid? LastMileDeviceId { get; set; }
    [ForeignKey(nameof(LastMileDeviceId))]
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
