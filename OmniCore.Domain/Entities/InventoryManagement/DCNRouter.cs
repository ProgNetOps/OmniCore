namespace OmniCore.Domain.Entities.InventoryManagement;

public class DCNRouter
{
    public Guid Id { get; set; }
    public IPPoP? IPPoP { get; set; }

    public string? RouterName { get; set; }
    public string? RouterType { get; set; }
    public string? ManagementIpAddress { get; set; }


}
