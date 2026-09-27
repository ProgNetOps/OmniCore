using OmniCore.Domain.Common;

namespace OmniCore.Domain.Entities.InventoryManagement;

/// <summary>
/// Represents the switch on which clients' services are provisioned/ configured
/// </summary>
public class Switch:AuditableEntity, INetworkElement
{
    public Guid SwitchId { get; set; }
    public ICollection<Router>? UplinkDCNRouters { get; set; }
    public ICollection<Router>? ConnectedGlo1Routers { get; set; }

    //INetworkElement implementation
    public string? BackupConfig { get; set; }
    public IPPoP? IPPoP { get; set; }
    public string? NetworkElementName { get; set; }
    public string? NetworkElementModel { get; set; }
    public NetworkElementType? NetworkElementType { get; set; }
    public OEM? EquipmentManufacturer { get; set; }
    public NEOwner NEOwner { get; set; }
    public string? ManagementIpAddress { get; set; }
    public Guid NetworkElementId { get; set; }
}