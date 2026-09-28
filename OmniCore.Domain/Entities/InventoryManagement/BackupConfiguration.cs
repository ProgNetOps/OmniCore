namespace OmniCore.Domain.Entities.InventoryManagement;
/// <summary>
/// An owned entity used by network elements
/// </summary>
public class BackupConfiguration:AuditableEntity
{
    public string? BackupConfig { get; set; }

}