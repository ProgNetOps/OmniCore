using OmniCore.Domain.Entities.ClientManagement;

namespace OmniCore.Domain.Entities.InventoryManagement;
/// <summary>
/// The base station where services are provisioned on network equipment for customers
/// </summary>
public class IPPoP
{
    public Guid IPPoPId { get; set; }
    /// <summary>
    /// Site Id of the point of Preference
    /// </summary>
    public string? IPPoPName { get; set; }
    public Guid? BTSId { get; set; }    
    public BTS? BTS { get; set; }
    /// <summary>
    /// List of switches at the PoP
    /// </summary>
    public ICollection<Switch>? Switches { get; set; }
    /// <summary>
    /// List of routers at the PoP
    /// </summary>
    public ICollection<Router>? Routers { get; set; }
    /// <summary>
    /// List of services to customers
    /// </summary>
    public ICollection<Link>? Links { get; set; }
}
