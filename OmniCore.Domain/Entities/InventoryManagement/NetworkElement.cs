using OmniCore.Domain.Entities.Enums;

namespace OmniCore.Domain.Entities.InventoryManagement;
public abstract class NetworkElement
{
    public Guid NetworkElementId { get; set; }
    public Guid IPPoPId { get; set; }
    public IPPoP? IPPoP { get; set; }

    /// <summary>
    /// The backup configuration of the device
    /// </summary>
    public BackupConfiguration? BackupConfiguration { get; set; }
    public string? NetworkElementName { get; set; }
    public string? NetworkElementModel { get; set; }
    public virtual NEType? NetworkElementType { get; set; }
    public OEM? EquipmentManufacturer { get; set; }
    public NEOwner NEOwner { get; set; }
    public string? ManagementIpAddress { get; set; }
}
