
using OmniCore.Domain.Entities.ClientManagement.Enums;
using OmniCore.Domain.Entities.InventoryManagement.LastMiles;

namespace OmniCore.Domain.Entities.ClientManagement;
/// <summary>
/// Class representing a service to a customer
/// </summary>
public class Link:AuditableEntity
{
    public Guid LinkId { get; set; }
    public string? LinkName { get; set; }
    public Guid ClientId { get; set; }
    public Client? Client { get; set; }
    public Address? LocationOfCustomer { get; set; }    
    public string? ClientContactDetails { get; set; }
    public Service? Service { get; set; }   
    public LinkState LinkState { get; set; }   
    public Guid LastMileId { get; set; }
    public LastMile? LastMile { get; set; }
    public AccountDetails? AccountDetails { get; set; }

}
