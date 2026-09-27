namespace OmniCore.Domain.Entities.InventoryManagement;

public class Router : INetworkElement
{
    public Guid RouterId {get; set;}
    public Guid IPPoPId { get; set; }
    public IPPoP? IPPoP { get; set; }
    public string? NetworkElementName { get; set; }
    public string? NetworkElementModel { get; set; }
    public NetworkElementType? NetworkElementType { get; set; }
    public OEM? EquipmentManufacturer { get; set; }
    public NEOwner NEOwner { get; set; }
    public string? ManagementIpAddress { get; set; }
    public Guid NetworkElementId { get; set; }
    public string? BackupConfig { get; set; }
}
