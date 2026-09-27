namespace OmniCore.Domain.Entities.InventoryManagement;
/// <summary>
/// The OEM of the NE eg Huawei, Cisco, Alcatel, Nera, Ceragon, HP, Dell, Aruba, TPLinkOmada
/// </summary>
public class OEM
{
    public Guid OEMId { get; set; }
    public string? OEMName { get; set; }
}
