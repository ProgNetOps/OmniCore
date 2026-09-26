using OmniCore.Domain.Common;

namespace OmniCore.Domain.Entities.InventoryManagement;

/// <summary>
/// Represents the switch on which clients' services are provisioned/ configured
/// </summary>
public class NetworkSwitch:AuditableEntity
{
    #region Properties
    public Guid Id { get; set; }


    /// <summary>
    /// Description of the switch from "Show running-config OR display current-config"
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Name of switch
    /// </summary>
    public string? SwitchName { get; set; }

    /// <summary>
    /// Switch IP for telnet/SSH sessions
    /// </summary>
    public string? ManagementIP { get; set; }

    /// <summary>
    /// Base station where switch is located
    /// </summary>
    public IPPoP? IPPoP { get; set; }

    /// <summary>
    /// The backup configuration of the switch
    /// </summary>
    public string? BackupConfig { get; set; }

    /// <summary>
    /// Splits the backup configuration string and returns the interfaces
    /// </summary>
    /// <returns></returns>


    public override string? ToString() => Description;

    */
    #endregion
}