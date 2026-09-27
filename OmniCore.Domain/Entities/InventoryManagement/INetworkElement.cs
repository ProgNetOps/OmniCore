namespace OmniCore.Domain.Entities.InventoryManagement;
public interface INetworkElement
{
    public Guid NetworkElementId { get; set; }
    /// <summary>
    /// The backup configuration of the device
    /// </summary>
    public string? BackupConfig { get; set; }
    public Guid IPPoPId { get; set; }
    public IPPoP? IPPoP { get; set; }
    public string? NetworkElementName { get; set; }
    public string? NetworkElementModel { get; set; }
    public NetworkElementType? NetworkElementType { get; set; }
    public OEM? EquipmentManufacturer { get; set; }
    public NEOwner NEOwner { get; set; }
    public string? ManagementIpAddress { get; set; }
}
