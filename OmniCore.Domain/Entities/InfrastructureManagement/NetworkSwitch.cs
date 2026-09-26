using OmniCore.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OmniCore.Domain.Entities.InfrastructureManagement;

/// <summary>
/// Represents the switch on which clients' services are provisioned/ configured
/// </summary>
public class NetworkSwitch:AuditableEntity
{
    #region Properties
    [Key]
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
    /// A collection of all the interfaces on the switch
    /// </summary>


    /// <summary>
    /// Last date of switch config backup
    /// </summary>[Required]
    public DateTime? DateOfLastBackup { get; set; }

    /// <summary>
    /// Splits the backup configuration string and returns the interfaces
    /// </summary>
    /// <returns></returns>


    public override string? ToString() => Description;


    /*//FOR LATER
    /// <summary>
    /// The staff who effected the last backup
    /// </summary>
    public int EmployeeId { get; set; }
    [ForeignKey(nameof(EmployeeId))]
    public Employee LastUpdatedBy { get; set; }
    */
    #endregion
}